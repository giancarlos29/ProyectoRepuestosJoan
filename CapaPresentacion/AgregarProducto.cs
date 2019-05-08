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
    public partial class AgregarProducto : Form
    {
        private static AgregarProducto frmInstance = null;
        Producto productoEntidad = new Producto();
        ProductosNegocio productosNegocio = new ProductosNegocio();
        ProveedoresNegocio proveedoresNegocio = new ProveedoresNegocio();
        CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
        private bool respuesta;
        private int productoID;
        int esNumerico;
        TextBox[] textBoxes;

        public static AgregarProducto Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new AgregarProducto();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public AgregarProducto()
        {
            InitializeComponent();
            textBoxes = new TextBox[] { txtReferencia, txtDescripcion, txtMarca, txtCodigoBarra, txtCalidad, txtPrecioCompra, txtPrecioVenta, txtDescuento, txtCantMin, txtCantMax };
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            txtReferencia.Select();            
            CargarCBCategoria();
            CargarCBProveedor();
            CargarCBITBIS();
        }

        private void CargarCBCategoria()
        {
            var result = categoriasNegocio.CargarCategoriasProd().ToList();

            foreach (proc_CargarTodasCategoriasProd_Result item in result)
            {
                cbCategoria.Items.Add(item.CategoriaProdID + "-" + item.Categoria);
            }
            cbCategoria.SelectedIndex = 0;
        }
        private void CargarCBProveedor()
        {
            var result = proveedoresNegocio.CargarTodosProveedores().ToList();

            foreach (proc_CargarTodosProveedores_Result item in result)
            {
                cbProveedor.Items.Add(item.ProveedorID + "-" + item.Nombre);
            }
            cbProveedor.SelectedIndex = 0;
        }

        private void CargarCBITBIS()
        {
            cbITBIS.Items.Add("true");
            cbITBIS.Items.Add("false");
            cbITBIS.SelectedIndex = 0;
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            BuscarProductos buscarProductos = null;
            buscarProductos = BuscarProductos.Instance();
            buscarProductos.MdiParent = this.MdiParent;
            buscarProductos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampoReferencia() && validarCampoDescripcion() && validarCampoCategoria() 
                && validarCampoExistencia() && validarCampoCategoria() && 
                validarCampoCompra() && validarCampoVenta() && validarCampoITBIS() &&
                validarCampoCantMax() && validarCampoCantMin())
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea agregar nuevo cliente?", "Nuevo Cliente", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    productoEntidad.Referencia = txtReferencia.Text;
                    productoEntidad.Descripcion = txtDescripcion.Text;
                    productoEntidad.CategoriaID = (int)char.GetNumericValue(cbCategoria.Text[0]);
                    productoEntidad.Marca = txtMarca.Text;
                    productoEntidad.CodigoBarra = txtCodigoBarra.Text;
                    productoEntidad.Calidad = txtCalidad.Text;
                    productoEntidad.ProveedorID = (int)char.GetNumericValue(cbProveedor.Text[0]);
                    productoEntidad.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                    productoEntidad.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    productoEntidad.ITBIS = Convert.ToBoolean(cbITBIS.Text);
                    productoEntidad.Descuento = Convert.ToDecimal(txtDescuento.Text);
                    productoEntidad.CantMin = Convert.ToDouble(txtCantMin.Text);
                    productoEntidad.CantMax = Convert.ToDouble(txtCantMax.Text);



                    var result = productosNegocio.AgregarProducto(productoEntidad);

                    respuesta = result.Item1;
                    productoID = result.Item2;
                    validarInsertProducto(respuesta, productoID);
                    btnLimpiar_Click(sender, e);
                }
                    
            }
            else
            {
                MessageBox.Show("Por favor complete los campos con error.");
            }

        }

        private void validarInsertProducto(bool respuesta, int productoID)
        {

            if (respuesta)
            {

                MessageBox.Show(string.Format("El producto ha sido agregado correctamente a la base de datos, con el numero de producto: {0}", productoID), "Producto Agregado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El producto no pudo ser agregado a la base de datos, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampoReferencia()
        {
            if (string.IsNullOrEmpty(txtReferencia.Text) || txtReferencia.Text.Trim().Length > 100)
            {
                errorProviderReferencia.Icon = Properties.Resources.error;
                errorProviderReferencia.SetError(txtReferencia, "El Campo REFERENCIA no puede estar vacio ni puede contener mas de 100 caracteres");
                return false;
            }
            else
            {
                errorProviderReferencia.Icon = Properties.Resources.yes;
                errorProviderReferencia.SetError(txtReferencia, "Correcto!");
                return true;
            }
        }

        private bool validarCampoDescripcion()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProviderDescripcion.Icon = Properties.Resources.error;
                errorProviderDescripcion.SetError(txtDescripcion, "El Campo DESCRIPCION no puede estar vacio");
                return false;
            }
            else
            {
                errorProviderDescripcion.Icon = Properties.Resources.yes;
                errorProviderDescripcion.SetError(txtDescripcion, "Correcto!");
                return true;
            }
        }
        private bool validarCampoCategoria()
        {

            if (string.IsNullOrEmpty(cbCategoria.Text) || cbCategoria.Text.Trim().Length > 200)
            {
                errorProviderCategoria.Icon = Properties.Resources.error;
                errorProviderCategoria.SetError(cbCategoria, "El Campo Categoria no puede estar vacio, por favor seleccionar un valor");
                return false;
            }
            else
            {
                errorProviderCategoria.Icon = Properties.Resources.yes;
                errorProviderCategoria.SetError(cbCategoria, "Correcto!");
                return true;
            }
        }

        private bool validarCampoExistencia()
        {
            if (nupExistencia.Value < 1)
            {
                errorProviderExistencia.Icon = Properties.Resources.error;
                errorProviderExistencia.SetError(nupExistencia, "El Campo Existencia no puede estar vacio o debe de ser mayor a 0");
                return false;
            }
            else
            {
                errorProviderExistencia.Icon = Properties.Resources.yes;
                errorProviderExistencia.SetError(nupExistencia, "Correcto!");
                return true;
            }
        }

        private bool validarCampoCompra()
        {
            if ((!int.TryParse(txtPrecioCompra.Text, out esNumerico)))
            {
                errorProviderCompra.Icon = Properties.Resources.error;
                errorProviderCompra.SetError(txtPrecioCompra, "El Campo CANTIDAD Minima no puede estar vacío o debe de tener valor mayor a 0");
                return false;
            }
            else
            {
                decimal val = Convert.ToDecimal(txtPrecioCompra.Text);
                if (val < 1)
                {
                    errorProviderCompra.Icon = Properties.Resources.error;
                    errorProviderCompra.SetError(txtPrecioCompra, "El Campo CANTIDAD Minima debe de tener valor mayor a 0");
                    return false;
                }
                else
                {
                    errorProviderCompra.Icon = Properties.Resources.yes;
                    errorProviderCompra.SetError(txtPrecioCompra, "Correcto!");
                    return true;
                }

            }

        }

        private bool validarCampoVenta()
        {
            if ((!int.TryParse(txtPrecioVenta.Text, out esNumerico)))
            {
                errorProviderVenta.Icon = Properties.Resources.error;
                errorProviderVenta.SetError(txtPrecioVenta, "El Campo CANTIDAD Minima no puede estar vacío o debe de tener valor mayor a 0");
                return false;
            }
            else
            {
                double val = Convert.ToDouble(txtPrecioVenta.Text);
                if (val < 1)
                {
                    errorProviderVenta.Icon = Properties.Resources.error;
                    errorProviderVenta.SetError(txtPrecioVenta, "El Campo CANTIDAD Minima debe de tener valor mayor a 0");
                    return false;
                }
                else
                {
                    errorProviderVenta.Icon = Properties.Resources.yes;
                    errorProviderVenta.SetError(txtPrecioVenta, "Correcto!");
                    return true;
                }
            }


        }

        private bool validarCampoITBIS()
        { 
         if (string.IsNullOrEmpty(cbITBIS.Text) || cbITBIS.Text.Trim().Length > 200)
            {
                errorProviderCategoria.Icon = Properties.Resources.error;
                errorProviderCategoria.SetError(cbITBIS, "El Campo ITBIS no puede estar vacio, por favor seleccionar un valor");
                return false;
            }
            else
            {
                errorProviderCategoria.Icon = Properties.Resources.yes;
                errorProviderCategoria.SetError(cbITBIS, "Correcto!");
                return true;
            }
        }
        private bool validarCampoCantMax()
        {
            if ((!int.TryParse(txtCantMax.Text, out esNumerico)))
            {
                errorProviderCantMax.Icon = Properties.Resources.error;
                errorProviderCantMax.SetError(txtCantMax, "El Campo CANTIDAD Minima no puede estar vacío o debe de tener valor mayor a 0");
                return false;
            }
            else
            {
                decimal val = Convert.ToDecimal(txtCantMax.Text);
                if (val < 1)
                {
                    errorProviderCantMax.Icon = Properties.Resources.error;
                    errorProviderCantMax.SetError(txtCantMax, "El Campo CANTIDAD Minima debe de tener valor mayor a 0");
                    return false;
                }
                else
                {
                    errorProviderCantMax.Icon = Properties.Resources.yes;
                    errorProviderCantMax.SetError(txtCantMax, "Correcto!");
                    return true;
                }
            }
        }
        private bool validarCampoCantMin()
        {

            if ((!int.TryParse(txtCantMin.Text, out esNumerico))) 
            {
                errorProviderCantMin.Icon = Properties.Resources.error;
                errorProviderCantMin.SetError(txtCantMin, "El Campo CANTIDAD Minima no puede estar vacío o debe de tener valor mayor a 0");
                return false;
            }
            else
            {
                decimal val = Convert.ToDecimal(txtCantMin.Text);
                if (val < 1)
                {
                    errorProviderCantMin.Icon = Properties.Resources.error;
                    errorProviderCantMin.SetError(txtCantMin, "El Campo CANTIDAD Minima debe de tener valor mayor a 0");
                    return false;
                }
                else
                { 
                    errorProviderCantMin.Icon = Properties.Resources.yes;
                    errorProviderCantMin.SetError(txtCantMin, "Correcto!");
                    return true;
                }
            }

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in textBoxes)
            {
                txtBox.Clear();
            }
            txtReferencia.Select();
            cbCategoria.SelectedIndex = 0;
            cbProveedor.SelectedIndex = 0;
            cbITBIS.SelectedIndex = 0;
        }

        private void AgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            BuscarProductos.verificar = true;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categorias ct = new Categorias();
            ct.Show();
        }
    }
}
