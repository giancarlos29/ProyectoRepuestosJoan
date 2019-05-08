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
    public partial class NotaDeCredito : Form
    {
        private int clienteID, facturaID, notaDeCreditoID, NCF;
        public static int numeroFactura;
        private static NotaDeCredito frmInstance = null;
        ClientesNegocio clientesNegocio = new ClientesNegocio();
        FacturasNegocio facturasNegocio = new FacturasNegocio();
        NotasDeCreditoNegocio notasDeCreditoNegocio = new NotasDeCreditoNegocio();
        CapaDatos.NotasDeCredito notasDeCreditoEntidad = new CapaDatos.NotasDeCredito();
        CapaDatos.DetalleNotaDeCredito detalleNotaDeCreditoEntidad = new CapaDatos.DetalleNotaDeCredito();
        DetalleNotasDeCreditoNegocio detalleNotasDeCreditoNegocio = new DetalleNotasDeCreditoNegocio();
        public static bool verificarProductosADevolver;
        CobrosVentaCreditoNegocio cobrosVentaCreditoNegocio = new CobrosVentaCreditoNegocio();
        CapaDatos.CobrosVentasCredito cobrosVentasCreditoEntidad = new CapaDatos.CobrosVentasCredito();
        LineasCreditoVentasNegocio lineasCreditoVentasNegocio = new LineasCreditoVentasNegocio();


        public static NotaDeCredito Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new NotaDeCredito();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public NotaDeCredito()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {
            LimpiarTxtFactura();
            CargarTxtNombreCliente();            
            
        }

        private void CargarCBFacturasPendientes()
        {
            var result = facturasNegocio.CargarFacturasPendientes(Convert.ToInt32(txtClienteID.Text)).ToList();
            if (result.Count != 0)
            {
                foreach (proc_CargarFacturasPendientes_Result item in result)
                {
                   
                  CBFacturasPendientes.Items.Add(item.FacturaID);                 
                    
                }
                CBFacturasPendientes.SelectedIndex = 0;
            }
        }

        private void CargarTxtNombreCliente()
        {
            if (!string.IsNullOrEmpty(txtClienteID.Text))
            {
                clienteID = Convert.ToInt32(txtClienteID.Text);   
      

                var result = clientesNegocio.BuscarClientesPorID(clienteID).FirstOrDefault();
                if(result != null)
                {
                    CargarCBFacturasPendientes();
                    txtClienteNombre.Text = result.Nombre.ToString();
                }
                else
                {
                    txtClienteNombre.Clear();
                    LimpiarCBFacturasPendiente();
                }
            }else
            {
                txtClienteNombre.Clear();
                LimpiarCBFacturasPendiente();
            }
        }

        private void LimpiarCBFacturasPendiente()
        {
            CBFacturasPendientes.Items.Clear();
            CBFacturasPendientes.ResetText();
        }

        private void txtFacturaID_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CBFacturasPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTxtMontoFactura();
            ReinicarDTDeProductosADevolver();
        }

        private void ReinicarDTDeProductosADevolver()
        {
            if (ProductosADevolver.dtProductosFactura != null && ProductosADevolver.dtProductosRecibidos != null)
            {
                ProductosADevolver.dtProductosRecibidos = null;
                ProductosADevolver.dtProductosFactura = null;
                txtCantProdDevueltos.Clear();
                txtValor.Clear();
                txtValorAAplicar.Clear();
            }
        }

        private void btnProductosDevolver_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFacturaID.Text) && !string.IsNullOrEmpty(txtClienteID.Text))
            {
                numeroFactura = Convert.ToInt32(txtFacturaID.Text);
                LlamarFormProductosADevolver();
                
            }
        }

        private void LlamarFormProductosADevolver()
        {
            if (facturasNegocio.ConfirmarFacturaYCliente(Convert.ToInt32(txtFacturaID.Text), Convert.ToInt32(txtClienteID.Text)))
            {
                ProductosADevolver productosADevolver = null;
                productosADevolver = ProductosADevolver.Instance();
                productosADevolver.ShowDialog();
                if (verificarProductosADevolver)
                    ActualizarValorYCantProductos();
                verificarProductosADevolver = false;

            }
            else
            {
                MessageBox.Show("# de Factura no existe en el cliente indicado...", "Verifique el numero de factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ActualizarValorYCantProductos()
        {
            txtCantProdDevueltos.Text = ProductosADevolver.cantProductosRecibidos.ToString();
            txtValor.Text = ProductosADevolver.valorProdRecibidos.ToString();
            txtValorAAplicar.Text = txtValor.Text;
            txtValorAAplicar.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtCantProdDevueltos.Text) > 0 && Convert.ToDecimal(txtValorAAplicar.Text) != 0)
            {
                if (CrearNotaDeCredito())
                {
                    AplicarNotaDeCredito();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Favor primero seleccionar productos para devolver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        
        private void AplicarNotaDeCredito()
        {
            cobrosVentasCreditoEntidad.LineaCreditoVentaID = lineasCreditoVentasNegocio.BuscarLineaDeCreditoVentaIDFactura(Convert.ToInt32(CBFacturasPendientes.Text));
            cobrosVentasCreditoEntidad.FechaCobro = System.DateTime.Now;
            cobrosVentasCreditoEntidad.Monto = Convert.ToDecimal(txtValorAAplicar.Text);
            cobrosVentasCreditoEntidad.UserID = Login.userID;
            cobrosVentasCreditoEntidad.Concepto = "Nota de credito";

            var result = cobrosVentaCreditoNegocio.InsertarCobroVentaCredito(cobrosVentasCreditoEntidad);

            if (result.Item1)
            {
                MessageBox.Show("Nota de Credito Aplicada Correctamente...", "Nota De Credito Aplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nota de Credito no pudo ser aplicada...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CrearNotaDeCredito()
        {
            notasDeCreditoEntidad.FacturaID = Convert.ToInt32(txtFacturaID.Text);
            notasDeCreditoEntidad.FacturaAplicarID = Convert.ToInt32(CBFacturasPendientes.Text);
            notasDeCreditoEntidad.Fecha = System.DateTime.Now;
            notasDeCreditoEntidad.UserID = Login.userID;
            NCF = Properties.Settings.Default.CNotaDeCredito + 1;
            notasDeCreditoEntidad.NCF = "00000000B04" + NCF.ToString("D8");
            notasDeCreditoEntidad.FechaVencimiento = Properties.Settings.Default.FechaVencimiento;
            notasDeCreditoEntidad.ValorAplicado = Convert.ToDecimal(txtValorAAplicar.Text);

            var result = notasDeCreditoNegocio.AgregarNotaDeCredito(notasDeCreditoEntidad);
            
            if (result.Item1)
            {
                notaDeCreditoID = result.Item2;
                MessageBox.Show(string.Format("La nota de credito {0} fue creada exitosamente...", notaDeCreditoID), "Nota De Credito Creada Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                CrearDetalleNotaDeCredito();
                Properties.Settings.Default.CNotaDeCredito = NCF;
                Properties.Settings.Default.Save();
                return true;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la crecion de la nota de credito...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CrearDetalleNotaDeCredito()
        {
            foreach (DataRow dtRow in ProductosADevolver.dtProductosRecibidos.Rows)
            {
                detalleNotaDeCreditoEntidad.NotaDeCreditoID = notaDeCreditoID;
                detalleNotaDeCreditoEntidad.ProductoID = Convert.ToInt32(dtRow[7]);
                detalleNotaDeCreditoEntidad.Precio = Convert.ToDecimal(dtRow[5]);
                detalleNotaDeCreditoEntidad.CantDevuelta = Convert.ToDouble(dtRow[0]);                
                detalleNotaDeCreditoEntidad.CantInventariada = Convert.ToDouble(dtRow[1]);
                detalleNotaDeCreditoEntidad.Comentario = Convert.ToString(dtRow[2]);

                detalleNotasDeCreditoNegocio.AgregarDetalleNotaDeCredito(detalleNotaDeCreditoEntidad);
                
            }
        }

        private void NotaDeCredito_Load(object sender, EventArgs e)
        {
            txtClienteID.Focus();
        }

        private void CargarTxtMontoFactura()
        {
            if (!string.IsNullOrEmpty(CBFacturasPendientes.Text))
            {          
                    facturaID = Convert.ToInt32(CBFacturasPendientes.Text);

                var result = facturasNegocio.CargarMontoFacturaNC(facturaID).FirstOrDefault();
                if(result != null)
                {
                    txtFechaFactura.Text = result.Fecha.ToString();
                    txtMontoFactura.Text = result.ValorFactura.ToString();
                    txtVPendienteFactura.Text = result.ValorPendiente.ToString();
                }
                else
                {
                    LimpiarTxtFactura();
                }

            }
            
        }

        private void LimpiarTxtFactura()
        {
            txtFechaFactura.Clear();
            txtMontoFactura.Clear();
            txtVPendienteFactura.Clear();
        }
    }
}
