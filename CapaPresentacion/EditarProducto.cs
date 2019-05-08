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
    public partial class EditarProducto : Form
    {
        private static EditarProducto frmInstance = null;
        ProductosNegocio productosNegocio = new ProductosNegocio();
        ProveedoresNegocio proveedoresNegocio = new ProveedoresNegocio();
        CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
        Producto productoEntidad = new Producto();
        TextBox[] textBoxes;
        private int indexCBCategoria;
        private int indexCBProveedor;

        public static EditarProducto Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new EditarProducto();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public EditarProducto()
        {
            InitializeComponent();
            textBoxes = new TextBox[] {txtReferencia, txtDescripcion, txtMarca, txtCodigoBarra, txtCalidad, txtExistencia, txtPrecioCompra, txtPrecioVenta, txtDescuento, txtCantMin, txtCantMax};
        }

        

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            if (Login.userLevel == 1)
                btnEliminarProducto.Enabled = true;

            var result = productosNegocio.BuscarProductosPorID(BuscarProductos.productoID).FirstOrDefault();
            indexCBCategoria = result.CategoriaID;
            indexCBProveedor = result.ProveedorID;
            txtProductoID.Text = BuscarProductos.productoID.ToString();
            txtReferencia.Text = result.Referencia;
            txtDescripcion.Text = result.Descripcion;            
            txtMarca.Text = result.Marca;
            txtCodigoBarra.Text = result.CodigoBarra;
            txtCalidad.Text = result.Calidad;            
            txtExistencia.Text = result.Existencia.ToString();
            txtPrecioCompra.Text = result.PrecioCompra.ToString();
            txtPrecioVenta.Text = result.PrecioVenta.ToString();
            txtDescuento.Text = result.Descuento.ToString();
            txtCantMin.Text = result.CantMin.ToString();
            txtCantMax.Text = result.CantMax.ToString();
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
            cbCategoria.SelectedIndex = indexCBCategoria-1;
        }

        private void CargarCBProveedor()
        {
            var result = proveedoresNegocio.CargarTodosProveedores().ToList();

            foreach (proc_CargarTodosProveedores_Result item in result)
            {
                cbProveedor.Items.Add(item.ProveedorID + "-" + item.Nombre);
            }
            cbProveedor.SelectedIndex = indexCBProveedor - 1;
        }

        private void CargarCBITBIS()
        {
            cbITBIS.Items.Add("True");
            cbITBIS.Items.Add("False");
            cbITBIS.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            productoEntidad.ProductoID = Convert.ToInt32(txtProductoID.Text);
            productoEntidad.Referencia = txtReferencia.Text;
            productoEntidad.Descripcion = txtDescripcion.Text;
            productoEntidad.CategoriaID = (int)char.GetNumericValue(cbCategoria.Text[0]);
            productoEntidad.Marca = txtMarca.Text;
            productoEntidad.CodigoBarra = txtCodigoBarra.Text;
            productoEntidad.Calidad = txtCalidad.Text;
            productoEntidad.ProveedorID = (int)char.GetNumericValue(cbProveedor.Text[0]); ;            
            productoEntidad.Existencia = Convert.ToDouble(txtExistencia.Text);
            productoEntidad.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            productoEntidad.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            productoEntidad.ITBIS = Convert.ToBoolean(cbITBIS.Text);
            productoEntidad.Descuento = Convert.ToDecimal(txtDescuento.Text);
            productoEntidad.CantMin = Convert.ToDouble(txtCantMin.Text);
            productoEntidad.CantMax = Convert.ToDouble(txtCantMax.Text);

            bool result = productosNegocio.EditarProducto(productoEntidad);
            ValidarEditarProducto(result);

        }

        public void ValidarEditarProducto(bool result)
        {
            if (result)
            {
                MessageBox.Show(string.Format("El producto ha sido editado correctamente en la base de datos."), "Producto Editado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El producto no pudo ser editado, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            BuscarProductos.verificar = true;
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
        

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            bool result = productosNegocio.BorrarProducto(Convert.ToInt32(txtProductoID.Text));
            ValidarBorrarProducto(result);
        }

        public void ValidarBorrarProducto(bool result)
        {
            if (result)
            {
                MessageBox.Show(string.Format("El producto ha sido borrado correctamente en la base de datos."), "Cliente Borrado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El producto no pudo ser borrado, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
