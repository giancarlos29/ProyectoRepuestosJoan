using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class InsertarCobroVentaCredito : Form
    {
        Thread hilo;
        private static InsertarCobroVentaCredito frmInstance = null;
        CapaDatos.CobrosVentasCredito cobrosVentasCreditoEntidad = new CapaDatos.CobrosVentasCredito();
        CobrosVentaCreditoNegocio cobrosVentaCreditoNegocio = new CobrosVentaCreditoNegocio();

        public static InsertarCobroVentaCredito Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new InsertarCobroVentaCredito();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public InsertarCobroVentaCredito()
        {
            InitializeComponent();
        }

        private void InsertarCobroVentaCredito_Load(object sender, EventArgs e)
        {
            CargarTextBox();
            txtPago.Focus();
        }

        private void CargarTextBox()
        {
            txtLineaCreditoVentaID.Text = Convert.ToString(LineasCreditoVentas.lineaVentaCreditoID);
            txtClienteID.Text = Convert.ToString(LineasCreditoVentas.clienteID);
            txtMontoPendiente.Text = Convert.ToString(LineasCreditoVentas.montoPendiente);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPago.Text != null)
            {
                if (ComprobarPagoLineaCreditoVenta())
                {
                    RealizarPago();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El valor del pago Excede el valor pendiente de la factura", "Monto Excedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                MessageBox.Show("Ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ComprobarPagoLineaCreditoVenta()
        {           
            if (cobrosVentaCreditoNegocio.ComprobarPagoLineaCreditoVenta(LineasCreditoVentas.lineaVentaCreditoID, Convert.ToDecimal(txtPago.Text)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RealizarPago()
        {
            cobrosVentasCreditoEntidad.LineaCreditoVentaID = LineasCreditoVentas.lineaVentaCreditoID;
            cobrosVentasCreditoEntidad.FechaCobro = System.DateTime.Now;
            cobrosVentasCreditoEntidad.Monto = Convert.ToDecimal(txtPago.Text);
            cobrosVentasCreditoEntidad.UserID = Login.userID;
            cobrosVentasCreditoEntidad.Concepto = "Pago Factura";

            var result = cobrosVentaCreditoNegocio.InsertarCobroVentaCredito(cobrosVentasCreditoEntidad);

            if (result.Item1)
            {
                CreacionThreadImpresora();
                MessageBox.Show(string.Format("Pago #{0} fue realizado correctamente", result.Item2), "Pago Aplicado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pago no fue aplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           


        }

        private void CreacionThreadImpresora()
        {
            //Creamos la instancia del hilo 
            hilo = new Thread(() => ImprimirComprobantePago());
            //Iniciamos el hilo 
            hilo.Start();
        }


        private void ImprimirComprobantePago()
        {
            ComprobantePagoLineaCreditoVenta comprobantePagoLineaCreditoVenta = null;
            comprobantePagoLineaCreditoVenta = ComprobantePagoLineaCreditoVenta.Instance();
            comprobantePagoLineaCreditoVenta.Visible = false;
            comprobantePagoLineaCreditoVenta.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
