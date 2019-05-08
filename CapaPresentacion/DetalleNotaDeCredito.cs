using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class DetalleNotaDeCredito : Form
    {
        DetalleNotasDeCreditoNegocio detalleNotasDeCreditoNegocio = new DetalleNotasDeCreditoNegocio();
        List<proc_CargarDetalleNotaDeCredito_Result> proc_CargarDetalleNotaDeCredito_Results;

        private static DetalleNotaDeCredito frmInstance = null;

        public static DetalleNotaDeCredito Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new DetalleNotaDeCredito();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public DetalleNotaDeCredito()
        {
            InitializeComponent();
        }

        private void DetalleNotaDeCredito_Load(object sender, EventArgs e)
        {
            CargarDGV();
            txtComentario.Clear();
        }

        private void CargarDGV()
        {
           proc_CargarDetalleNotaDeCredito_Results = detalleNotasDeCreditoNegocio.CargarDetalleNotaDeCredito(BuscarNotasDeCredito.notaDeCreditoID).ToList();
           dgvProductos.DataSource = proc_CargarDetalleNotaDeCredito_Results;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCodigo.Checked == true)
                dgvProductos.DataSource = proc_CargarDetalleNotaDeCredito_Results.Where(p => p.ProductoID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnReferencia.Checked == true)
                dgvProductos.DataSource = proc_CargarDetalleNotaDeCredito_Results.Where(p => p.Referencia.Contains(txtBuscar.Text)).ToList();
            if (rbtnDescripcion.Checked == true)
                dgvProductos.DataSource = proc_CargarDetalleNotaDeCredito_Results.Where(p => p.Descripcion.ToString().Contains(txtBuscar.Text)).ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Selected = true;
            txtComentario.Text = Convert.ToString(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[6].Value);
        }
    }
}
