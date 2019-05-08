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
    public partial class BuscarFacturasVenta : Form
    {
        List<proc_CargarTodasFacturas_Result> proc_CargarTodasFacturas_Results;
        FacturasNegocio facturasNegocio = new FacturasNegocio();
        private static BuscarFacturasVenta frmInstance = null;
        public static int facturaID;

        public static BuscarFacturasVenta Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new BuscarFacturasVenta();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public BuscarFacturasVenta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarFacturasVenta_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void CargarDGV()
        {
            proc_CargarTodasFacturas_Results = facturasNegocio.CargarTodasFacturas().ToList();
            dgvFacturas.DataSource = proc_CargarTodasFacturas_Results;
        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFacturas.Rows[dgvFacturas.CurrentRow.Index].Selected = true;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarVariableNotaDeCreditoID();
            AbrirFormDetalleFacturaVenta();
        }

        private void CargarVariableNotaDeCreditoID()
        {
            facturaID = Convert.ToInt32(dgvFacturas.Rows[dgvFacturas.CurrentRow.Index].Cells[0].Value);
        }

        private void AbrirFormDetalleFacturaVenta()
        {
            DetalleFacturaVenta detalleFacturaVenta = null;
            detalleFacturaVenta = DetalleFacturaVenta.Instance();
            detalleFacturaVenta.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCliente.Checked == true)
                dgvFacturas.DataSource = proc_CargarTodasFacturas_Results.Where(p => p.ClienteID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnFecha.Checked == true)
                dgvFacturas.DataSource = proc_CargarTodasFacturas_Results.Where(p => p.Fecha.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnID.Checked == true)
                dgvFacturas.DataSource = proc_CargarTodasFacturas_Results.Where(p => p.FacturaID.ToString().Contains(txtBuscar.Text)).ToList();
        }
    }
}
