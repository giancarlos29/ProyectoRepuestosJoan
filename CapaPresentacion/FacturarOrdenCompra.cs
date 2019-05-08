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
    public partial class FacturarOrdenCompra : Form
    {
        private static FacturarOrdenCompra frmInstance = null;
        ProveedoresNegocio proveedoresNegocio = new ProveedoresNegocio();
        OrdenesCompraNegocio ordenesCompraNegocio = new OrdenesCompraNegocio();
        FacturasCompra facturasCompraEntidad = new FacturasCompra();
        FacturaOrdenCompraNegocio FacturaOrdenCompraNegocio = new FacturaOrdenCompraNegocio();
        TiposPagosNegocio tiposPagosNegocio = new TiposPagosNegocio();

        public static FacturarOrdenCompra Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new FacturarOrdenCompra();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }
       
        public FacturarOrdenCompra()
        {
            InitializeComponent();
        }

        private void FacturarOrdenCompra_Load(object sender, EventArgs e)
        {
            LlenarTextBox();
            CargarCBTipoPago();
        }

        private void LlenarTextBox()
        {
            var result = proveedoresNegocio.BuscarProveedoresPorID(OrdenesCompras.proveedorID).FirstOrDefault();
            txtCodProveedor.Text = OrdenesCompras.proveedorID.ToString();
            txtNomProveedor.Text = result.Nombre;
            txtOrdenCompraID.Text = OrdenesCompras.ordenCompraID.ToString();
            txtFVSecuencia.Text = Convert.ToString(Properties.Settings.Default.FechaVencimiento);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void CargarCBTipoPago()
         {
                var result = tiposPagosNegocio.CargarTodosTiposPagos().ToList();

                foreach (proc_CargarTodosTiposPagos_Result item in result)
                {
                    cbTipoPago.Items.Add(item.TipoPagoID + "-" + item.TipoDePago);
                }
                cbTipoPago.SelectedIndex = 0;
         }
        

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            CrearFacturaCompra();
            CerrarOrdenCompra(Convert.ToInt32(txtOrdenCompraID.Text));
            OrdenesCompras.verificarCreacionFacturaCompra = true;
            this.Close();
            

        }
        private void CerrarOrdenCompra(int ordenCompraID)
        {
            ordenesCompraNegocio.CerrarOrdenCompra(ordenCompraID);
        }

        private void CrearFacturaCompra()
        {
            facturasCompraEntidad.ProveedorID = Convert.ToInt32(txtCodProveedor.Text);
            facturasCompraEntidad.OrdenCompraID = Convert.ToInt32(txtOrdenCompraID.Text);
            facturasCompraEntidad.NCF = txtNCFiscal.Text;
            facturasCompraEntidad.FechaVencimientoSecuencia = Convert.ToDateTime(txtFVSecuencia.Text);
            facturasCompraEntidad.FechaFactura = Convert.ToDateTime(txtFechaFactura.Text);
            facturasCompraEntidad.TipoDePagoID = (int)char.GetNumericValue(cbTipoPago.Text[0]);
            facturasCompraEntidad.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            facturasCompraEntidad.ITBIS = Convert.ToDecimal(txtITBIS.Text);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }

        private void LimpiarTxt()
        {
            txtFechaFactura.Clear();
            txtITBIS.Clear();
            txtNCFiscal.Clear();
            txtSubTotal.Clear();
        }
    }
}
