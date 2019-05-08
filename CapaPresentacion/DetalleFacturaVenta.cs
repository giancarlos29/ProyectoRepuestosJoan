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
    public partial class DetalleFacturaVenta : Form
    {
        List<proc_CargarDetalleFacturaVenta_Result> proc_CargarDetalleFacturaVenta_Results;
        DetalleFacturasNegocio detalleFacturasNegocio = new DetalleFacturasNegocio();
        private static DetalleFacturaVenta frmInstance = null;
        private double itbis, descuento, subtotal;

        public static DetalleFacturaVenta Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new DetalleFacturaVenta();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public DetalleFacturaVenta()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void DetalleFacturaVenta_Load(object sender, EventArgs e)
        {
            CargarDGV();
            CargarVariables();
            CargarTxtFactura();
        }

        private void CargarTxtFactura()
        {                     
            txtCantidad.Text = Convert.ToString(dgvProductos.Rows.Count);
            txtITBIS.Text = Convert.ToString(itbis);
            txtDescuento.Text = Convert.ToString(descuento);
            txtSubTotal.Text = Convert.ToString(subtotal);
            txtTotal.Text = Convert.ToString(subtotal + itbis - descuento);
        }

        private void CargarVariables()
        {
            itbis = 0;
            descuento = 0;
            subtotal = 0;           

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                itbis += Convert.ToDouble(row.Cells[5].Value);
                descuento += Convert.ToDouble(row.Cells[6].Value);
                subtotal += Convert.ToDouble(row.Cells[4].Value);                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCodigo.Checked == true)
                dgvProductos.DataSource = proc_CargarDetalleFacturaVenta_Results.Where(p => p.ProductoID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnDescripcion.Checked == true)
                dgvProductos.DataSource = proc_CargarDetalleFacturaVenta_Results.Where(p => p.Descripcion.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnReferencia.Checked == true)
                dgvProductos.DataSource = proc_CargarDetalleFacturaVenta_Results.Where(p => p.Referencia.ToString().Contains(txtBuscar.Text)).ToList();
        }

        private void CargarDGV()
        {
            proc_CargarDetalleFacturaVenta_Results = detalleFacturasNegocio.CargarDetalleFacturaVenta(BuscarFacturasVenta.facturaID).ToList();
            dgvProductos.DataSource = proc_CargarDetalleFacturaVenta_Results;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Selected = true;
        }
    }
}
