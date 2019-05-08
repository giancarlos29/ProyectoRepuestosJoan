using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class BuscarNotasDeCredito : Form
    {
        List<proc_CargarTodasNotasDeCredito_Result> proc_CargarTodasNotasDeCredito;
        NotasDeCreditoNegocio notasDeCreditoNegocio = new NotasDeCreditoNegocio();
        private static BuscarNotasDeCredito frmInstance = null;
        public static int notaDeCreditoID;

        public static BuscarNotasDeCredito Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new BuscarNotasDeCredito();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public BuscarNotasDeCredito()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void rbtnFecha_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {
           proc_CargarTodasNotasDeCredito = notasDeCreditoNegocio.CargarTodasNotasDeCredito().ToList();
           dgvNotasCredito.DataSource = proc_CargarTodasNotasDeCredito;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCliente.Checked == true)
                dgvNotasCredito.DataSource = proc_CargarTodasNotasDeCredito.Where(p => p.ClienteID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnFactura.Checked == true)
                dgvNotasCredito.DataSource = proc_CargarTodasNotasDeCredito.Where(p => p.FacturaID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnID.Checked == true)
                dgvNotasCredito.DataSource = proc_CargarTodasNotasDeCredito.Where(p => p.NotaDeCreditoID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnFecha.Checked == true)
                dgvNotasCredito.DataSource = proc_CargarTodasNotasDeCredito.Where(p => p.Fecha.ToString().Contains(txtBuscar.Text)).ToList();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarVariableNotaDeCreditoID();
            AbrirFormDetalleNotaDeCredito();
        }

        private void CargarVariableNotaDeCreditoID()
        {
            notaDeCreditoID = Convert.ToInt32(dgvNotasCredito.Rows[dgvNotasCredito.CurrentRow.Index].Cells[0].Value);
        }

        private void AbrirFormDetalleNotaDeCredito()
        {
            DetalleNotaDeCredito detalleNotaDeCredito = null;
            detalleNotaDeCredito = DetalleNotaDeCredito.Instance();
            detalleNotaDeCredito.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNotasCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNotasCredito.Rows[dgvNotasCredito.CurrentRow.Index].Selected = true;
        }
    }
}
