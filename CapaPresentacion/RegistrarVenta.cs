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
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Threading;

namespace CapaPresentacion
{
    public partial class RegistrarVenta : Form
    {
         
        public bool valida = false;
        private int contFila = 0;       
        private decimal total = 0;
        private int facturaID, clienteID, productoID, numFila, NCF;
        ClientesNegocio clientesNegocio = new ClientesNegocio();
        ProductosNegocio productosNegocio = new ProductosNegocio();
        TiposPagosNegocio tiposPagosNegocio = new TiposPagosNegocio();
        DetalleFacturasNegocio detalleFacturasNegocio = new DetalleFacturasNegocio();
        FacturasNegocio facturasNegocio = new FacturasNegocio();
        Factura facturaEntidad = new Factura();
        DetalleFactura detalleFacturaEntidad = new DetalleFactura();
        Producto productoEntidad = new Producto();
        TiposFacturaNegocio tiposFacturaNegocio = new TiposFacturaNegocio();
        LineasCreditoVenta lineasCreditoVentaEntidad = new LineasCreditoVenta();
        LineasCreditoVentasNegocio lineasCreditoVentasNegocio = new LineasCreditoVentasNegocio();
        private string codigoBarra, referencia;     
        private bool existe, resultado;       
        private decimal descuento, campoPrecio;
        private decimal precioTotalProd, ITBIS, itbisTotal, 
            subTotal, descuentoTotal, descuentoCliente,
            campoITBIS, campoDescuento,descuentoClientePorciento;
        private double existenciaProd, cantProdFinal;
        Thread hilo;

      

        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClienteID.Text))
            { 
                try
                {
                    BuscarDatosClientes();
                    Convert.ToInt32(txtClienteID.Text);
                    ePCodigo.Icon = Properties.Resources.yes;
                    ePCodigo.SetError(txtClienteID, "Correcto!");
                    valida = true;
                }
                catch (Exception exec)
                {
                    ePCodigo.Icon = Properties.Resources.error;
                    ePCodigo.SetError(txtClienteID, "Por favor considera que este campo solo admite números");
                }
            }
            else
            {
                txtClienteID.Clear();
                txtNombreCliente.Clear();
                txtDescuentoCliente.Clear();
            }
        }

        private void BuscarDatosClientes()
        {
            if (string.IsNullOrEmpty(txtClienteID.Text))
                clienteID = 0;
            else if ( clienteID.GetType() == typeof(int))
                clienteID = Convert.ToInt32(txtClienteID.Text);

            var result = clientesNegocio.BuscarClientesPorID(clienteID).FirstOrDefault();

            if (result != null)
            {
                txtNombreCliente.Text = result.Nombre.ToString();
                txtDescuentoCliente.Text = result.Descuento.ToString();
            }
            else
            {
                txtNombreCliente.Clear();
                txtDescuentoCliente.Clear();
            }            
        }

        private void BuscarDatosProducto()
        {
            if (string.IsNullOrEmpty(txtCodigoBarra.Text)) {
                txtDescripcion.Clear();
                txtCantidad.Text = 1.ToString();
                txtPrecioVenta.Clear();
            }
            else
            {
                codigoBarra = txtCodigoBarra.Text;

                var result = productosNegocio.BuscarProductosPorCodigoBarra(codigoBarra).FirstOrDefault();

                if (result != null)
                {
                    txtDescripcion.Text = result.Descripcion;
                    txtCantidad.Text = "1";
                    txtPrecioVenta.Text = result.PrecioVenta.ToString();

                    productoID = result.ProductoID;
                    codigoBarra = result.CodigoBarra;
                    referencia = result.Referencia;
                    if (result.ITBIS)
                    {

                        ITBIS = Properties.Settings.Default.ITBIS / 100;
                    }
                    else
                    {
                        ITBIS = 0;
                    }

                    if (result.Descuento > 0)
                    {
                        descuento = (result.Descuento) / 100;
                    }
                    else
                    {
                        descuento = 0;
                    }
                }
                else
                {
                    txtDescripcion.Clear();
                    txtCantidad.ResetText();
                    txtPrecioVenta.Clear();
                }
            }          
                
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            CargarCBTipoPago();
            CargarCBTipoFactura();
            this.AcceptButton = btnColocar;
            txtCodigoBarra.Select();
        }
        private void ColocarProdCarrito()
        {
            if (VerificarCantidadProducto())
            {
                LlevarProdCarrito();
                CalcularTotalFactura();
            }   
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            BuscarDatosProducto();
        }

        private bool ActualizarCantProducto()
        {
            // Coge la cantidad y codigo de barra del carrito para actualizar cantidad de tosos los productos
            if (dgvCarrito.Rows.Count != 0)
            {
                foreach (DataGridViewRow Fila in dgvCarrito.Rows)
                {
                    productoEntidad.Existencia = Convert.ToDouble(Fila.Cells[4].Value);
                    productoEntidad.CodigoBarra = Convert.ToString(Fila.Cells[1].Value);
                    resultado = productosNegocio.ActualizarCantidadProducto(productoEntidad);
                }
            }            
            return resultado;
        }
        

        private bool VerificarCantidadProducto()
        {
             if (string.IsNullOrEmpty(txtCodigoBarra.Text) == false || string.IsNullOrEmpty(txtDescripcion.Text) == false || string.IsNullOrEmpty(txtPrecioVenta.Text) == false || string.IsNullOrEmpty(txtCantidad.Text) == false)
                {
                //verificar cant de producto
                var result = productosNegocio.BuscarCantidadProductosPorCodigoBarra(codigoBarra).FirstOrDefault();

                if (result != null)
                {
                    existenciaProd = result.Existencia;
                    if (ConfirmarCant(existenciaProd))
                    {
                        return true;
                    }                  
                } 
                else
                {
                    MessageBox.Show(string.Format("El Producto con Codigo de Barra: {0} No Existe en almacen...", txtCodigoBarra.Text), "El Producto No Existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private bool ConfirmarCant(double existenciaProd)
        {
            cantProdFinal = Convert.ToDouble(txtCantidad.Text);
            if (dgvCarrito.Rows.Count != 0)
            {
                foreach (DataGridViewRow Fila in dgvCarrito.Rows)
                {
                    if (Convert.ToString(Fila.Cells[1].Value) == txtCodigoBarra.Text)
                    {
                        cantProdFinal = Convert.ToDouble(Fila.Cells[4].Value) + Convert.ToDouble(txtCantidad.Text);
                        break;
                    }
                }               
            }
            return CantidadConfirmadaProd(cantProdFinal);
        }
        private bool CantidadConfirmadaProd(double cantProdFinal)
        {
                if (cantProdFinal > existenciaProd)
                {
                    MessageBox.Show(string.Format("Cantidad del Producto de Codigo de Barra: {0} No disponible en almacen...", txtCodigoBarra.Text), "Cantidad Insuficiente del producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
        }
        

        private void LlevarProdCarrito()
        {
            existe = false;
            numFila = 0;
            total = 0;

            if (contFila == 0)
            {               
                campoPrecio = Convert.ToDecimal(txtPrecioVenta.Text) -(Convert.ToDecimal(txtPrecioVenta.Text) *  ITBIS) ;
                campoDescuento = campoPrecio * descuento;
                campoITBIS = Convert.ToDecimal(txtPrecioVenta.Text) * ITBIS;
                dgvCarrito.Rows.Add(productoID, txtCodigoBarra.Text, referencia, txtDescripcion.Text, txtCantidad.Text, campoPrecio.ToString("F"), campoITBIS.ToString("F"), campoDescuento.ToString("F"));

                precioTotalProd = Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[4].Value) * (Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[5].Value) + Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[6].Value) - Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[7].Value));

                dgvCarrito.Rows[contFila].Cells[8].Value = precioTotalProd.ToString("F");
                contFila++;
            }
            else
            {
                foreach (DataGridViewRow Fila in dgvCarrito.Rows)
                {
                    if (Fila.Cells[1].Value.ToString() == txtCodigoBarra.Text)
                    {
                        existe = true;
                        numFila = Fila.Index;
                    }
                }

                if (existe == true)
                {                    
                    dgvCarrito.Rows[numFila].Cells[4].Value = Convert.ToDecimal(txtCantidad.Value) + Convert.ToDecimal(dgvCarrito.Rows[numFila].Cells[4].Value);

                    precioTotalProd = Convert.ToDecimal(dgvCarrito.Rows[numFila].Cells[4].Value) * (Convert.ToDecimal(dgvCarrito.Rows[numFila].Cells[5].Value) + Convert.ToDecimal(dgvCarrito.Rows[numFila].Cells[6].Value) - Convert.ToDecimal(dgvCarrito.Rows[numFila].Cells[7].Value));
                    dgvCarrito.Rows[numFila].Cells[8].Value = precioTotalProd.ToString("F");
                }
                else
                {
                    campoPrecio = Convert.ToDecimal(txtPrecioVenta.Text) - (Convert.ToDecimal(txtPrecioVenta.Text) * ITBIS);
                    campoDescuento = campoPrecio * descuento;
                    campoITBIS = Convert.ToDecimal(txtPrecioVenta.Text) * ITBIS;
                    dgvCarrito.Rows.Add(productoID, txtCodigoBarra.Text, referencia, txtDescripcion.Text, txtCantidad.Text, campoPrecio.ToString("F"), campoITBIS.ToString("F"), campoDescuento.ToString("F"));

                    precioTotalProd = Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[4].Value) * (Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[5].Value) + Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[6].Value) - Convert.ToDecimal(dgvCarrito.Rows[contFila].Cells[7].Value));
                    dgvCarrito.Rows[contFila].Cells[8].Value = precioTotalProd.ToString("F");
                    contFila++;
                }
            }            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CalcularTotalFactura()
        {
            itbisTotal = 0;
            descuentoTotal = 0;
            subTotal = 0;
            descuentoCliente = 0;
            
            foreach (DataGridViewRow Fila in dgvCarrito.Rows)
            {               
                itbisTotal += Convert.ToDecimal(Fila.Cells[6].Value) * Convert.ToDecimal(Fila.Cells[4].Value);
                descuentoTotal += Convert.ToDecimal(Fila.Cells[7].Value) * Convert.ToDecimal(Fila.Cells[4].Value);
                subTotal += Convert.ToDecimal(Fila.Cells[5].Value) * Convert.ToDecimal(Fila.Cells[4].Value);
               

            }

            if (string.IsNullOrEmpty(txtDescuentoCliente.Text))
                { 
                descuentoClientePorciento = 0;
                }
            else
                {
                descuentoClientePorciento = (decimal.Parse(txtDescuentoCliente.Text)) / 100;
                }
            
            descuentoCliente = ((subTotal + itbisTotal) * descuentoClientePorciento) + descuentoTotal;
            total = subTotal + itbisTotal - descuentoCliente;
            txtTotal.Text = "RD$ " + total.ToString("F");
            txtSubTotal.Text =subTotal.ToString("F");
            txtItbis.Text = itbisTotal.ToString("F");
            txtDescuento.Text = descuentoCliente.ToString("F");
            txtCantArticulos.Text = dgvCarrito.Rows.Count.ToString();
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {
            ColocarProdCarrito();
            txtCodigoBarra.Clear();
            txtDescripcion.Clear();
            txtCantidad.Value = 1;
            txtPrecioVenta.Clear();
            txtCodigoBarra.Select();

        }

        private void RegistrarVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void RegistrarVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contFila > 0)            {
               
                dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index);
                total = 0;
                subTotal = 0;
                itbisTotal = 0;
                descuentoTotal = 0;
                CalcularTotalFactura();
                contFila--;
            }
            txtCodigoBarra.Select();
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Esta Seguro que desea cerrar el formulario de ventas?", "Confirme para salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    txtCodigoBarra.Select();
                }
            }
            else
            {
                this.Close();
            }           
        }

        private void checkboxClienteAnonimo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxClienteAnonimo.Checked == true)
            {                
                txtClienteID.Enabled = false;
                txtNombreCliente.Enabled = false;
                txtDescuentoCliente.Enabled = false;
                btnBuscar.Enabled = false;
                txtClienteID.Text = "1";
                txtDescuento.Text = "0";
                txtNombreCliente.Text = "Cliente Anonimo";

               
            }
            else
            {                
                txtClienteID.Enabled = true;
                txtNombreCliente.Enabled = true;
                txtDescuentoCliente.Enabled = true;
                btnBuscar.Enabled = true;

                txtClienteID.Clear();
                txtNombreCliente.Clear();
                txtDescuentoCliente.Clear();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarClientes buscarClientes = null;
            buscarClientes = BuscarClientes.Instance();
            buscarClientes.MdiParent = this.MdiParent;
            buscarClientes.ShowDialog();
        }        

        private void dgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCarrito.Rows[dgvCarrito.CurrentRow.Index].Selected = true;
        }

        private void RegistrarVenta_Activated(object sender, EventArgs e)
        {
            if(BuscarClientes.clienteID != 0)
            txtClienteID.Text = BuscarClientes.clienteID.ToString();
        }

        private void LimpiarFormulario()
        {
            dgvCarrito.Rows.Clear();
            dgvCarrito.Refresh();
            total = 0;
            subTotal = 0;
            itbisTotal = 0;
            descuentoTotal = 0;
            txtCodigoBarra.Clear();
            txtDescripcion.Clear();
            txtCantidad.Value = 1;
            txtPrecioVenta.Clear();
            txtCodigoBarra.Select();
            txtClienteID.Clear();
            txtNombreCliente.Clear();
            cbTipoFactura.SelectedIndex = 0;
            cbTipoPago.SelectedIndex = 0;
            txtRNC.Clear();
            txtNombre.Clear();
            checkboxClienteAnonimo.Checked = false;
            CalcularTotalFactura();
            contFila = 0;

        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {            
            dgvCarrito.Rows.Clear();
            dgvCarrito.Refresh();
            total = 0;
            subTotal = 0;
            itbisTotal = 0;
            descuentoTotal = 0;
            CalcularTotalFactura();
            txtCodigoBarra.Select();
            contFila = 0;
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

        private void CargarCBTipoFactura()
        {
            var result = tiposFacturaNegocio.CargarTodosTiposFactura().ToList();

            foreach (proc_CargarTodosTiposFactura_Result item in result)
            {
                cbTipoFactura.Items.Add(item.TipoFacturaID + "-" + item.TipoFactura);
            }
            cbTipoFactura.SelectedIndex = 0;
        }

        private void cbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoFactura.Text.FirstOrDefault().ToString() == "1")
            {
                txtRNC.Clear();
                txtNombre.Clear();

                txtNombre.Enabled = false;
                txtRNC.Enabled = false;
            }
            else if (cbTipoFactura.Text.FirstOrDefault().ToString() == "2")
            {
                txtNombre.Enabled = true;
                txtRNC.Enabled = true;
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

            if (contFila != 0)
            {
               if (cbTipoPago.Text.FirstOrDefault().ToString() == "3" || cbTipoPago.Text.FirstOrDefault().ToString() == "4") {
                    if (clientesNegocio.VerificarCredito(Convert.ToInt32(txtClienteID.Text),Convert.ToDecimal(txtTotal.Text))) {
                        VerificarTipoFactura();
                        CrearLineaCreditoVenta();
                        

                    }
                    else
                    {
                        MessageBox.Show("Cliente no posee creditos suficientes para la compra...", "Creditos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    VerificarTipoFactura();
                }
            }
        }
        private void CrearLineaCreditoVenta()
        {
            lineasCreditoVentaEntidad.FacturaID = facturaID;
            lineasCreditoVentaEntidad.Estatus = false;
            lineasCreditoVentasNegocio.InsertarLineaCreditoVenta(lineasCreditoVentaEntidad);
        }

        private void VerificarTipoFactura()
        {
            if (cbTipoFactura.Text.FirstOrDefault().ToString() == "1")
            {
                CrearFacturaCFinal();
                ActualizarCantProducto();
                CreacionThreadImpresora("1");

            }
            else if (cbTipoFactura.Text.FirstOrDefault().ToString() == "2")
            {
                CrearFacturaComprobante();
                ActualizarCantProducto();
                CreacionThreadImpresora("2");

            }

            MessageBox.Show("Venta realizada correctamente!", "Venta completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void CreacionThreadImpresora(string tipoFactura)
        {                       
            //Creamos la instancia del hilo 
            hilo = new Thread(() => ImprimirFactura(tipoFactura));                        
            //Iniciamos el hilo 
            hilo.Start();
            
        }        

        private void ImprimirFactura(string tipoFactura)
        {
            switch (tipoFactura)
            {
                case "1":
                    ReporteDetalleFactura reporteDetalleFactura = null;
                    reporteDetalleFactura = ReporteDetalleFactura.Instance();                 
                    reporteDetalleFactura.Visible = false;
                    reporteDetalleFactura.Show();
                    break;
                case "2":
                    ReporteDetalleFacturaFiscal reporteDetalleFacturaFiscal = null;
                    reporteDetalleFacturaFiscal = ReporteDetalleFacturaFiscal.Instance();                    
                    reporteDetalleFacturaFiscal.Visible = false;
                    reporteDetalleFacturaFiscal.Show();
                    break;
                default:
                    break;
            }
        }
        private void CrearFacturaCFinal()
        {
            if (checkboxClienteAnonimo.Checked == true)
            {
                facturaEntidad.ClienteID = 1;
            }
            else
            {
                facturaEntidad.ClienteID = Convert.ToInt32(txtClienteID.Text);
            }
                NCF = Properties.Settings.Default.CFinalSecuencia + 1;               
                facturaEntidad.Fecha = DateTime.Now;
                facturaEntidad.TipoPagoID = (int)char.GetNumericValue(cbTipoPago.Text[0]);
                facturaEntidad.TipoFacturaID = (int)char.GetNumericValue(cbTipoFactura.Text[0]);
                facturaEntidad.NCF = "00000000B02" + NCF.ToString("D8");
                facturaEntidad.UserID = Login.userID;
                facturaEntidad.RNC = null;
                facturaEntidad.Entidad = null;
                facturaEntidad.FechaVencimiento = null;                

                var result = facturasNegocio.InsertarFactura(facturaEntidad);
                if (result.Item1)
                {
                    Properties.Settings.Default.CFinalSecuencia = NCF;
                    Properties.Settings.Default.Save();
                    facturaID = result.Item2;                   
                    CrearDetalleFactura();
                }            
        }

        private void CrearFacturaComprobante()
        {
            if (checkboxClienteAnonimo.Checked == true)
            {
                facturaEntidad.ClienteID = 1;
            }
            else
            {
                facturaEntidad.ClienteID = Convert.ToInt32(txtClienteID.Text);
            }

            NCF = Properties.Settings.Default.CFiscalSecuencia + 1;
            facturaEntidad.Fecha = DateTime.Now;
            facturaEntidad.TipoPagoID = (int)char.GetNumericValue(cbTipoPago.Text[0]);
            facturaEntidad.TipoFacturaID = (int)char.GetNumericValue(cbTipoFactura.Text[0]);
            facturaEntidad.NCF = "00000000B01" + NCF.ToString("D8");
            facturaEntidad.UserID = Login.userID;
            facturaEntidad.RNC = txtRNC.Text;
            facturaEntidad.Entidad = txtNombre.Text;
            facturaEntidad.FechaVencimiento = Properties.Settings.Default.FechaVencimiento;

            var result = facturasNegocio.InsertarFactura(facturaEntidad);
            if (result.Item1)
            {
                Properties.Settings.Default.CFiscalSecuencia = NCF;
                Properties.Settings.Default.Save();
                facturaID = result.Item2;
                CrearDetalleFactura();
            }
        }

        public void CrearDetalleFactura()
        {
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                detalleFacturaEntidad.FacturaID = facturaID;
                detalleFacturaEntidad.ProductoID = Convert.ToInt32(fila.Cells[0].Value);
                detalleFacturaEntidad.CantVen = Convert.ToDouble(fila.Cells[4].Value);
                detalleFacturaEntidad.Precio =  Convert.ToDecimal(fila.Cells[5].Value);
                detalleFacturaEntidad.ITBIS = Convert.ToDecimal(fila.Cells[6].Value);
                detalleFacturaEntidad.Descuento = Convert.ToDecimal(fila.Cells[7].Value);

                var result = detalleFacturasNegocio.InsertarDetalleFactura(detalleFacturaEntidad);
             
            }
        }

        private void checkboxColocarAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxColocarAuto.Checked == true)
            {
                this.AcceptButton = btnColocar;
            }
            else
            {
                this.AcceptButton = null;
            }
        }


        private void txtClienteID_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }
    }
}
      
