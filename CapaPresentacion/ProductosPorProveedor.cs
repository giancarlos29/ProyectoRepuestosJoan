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
    public partial class ProductosPorProveedor : Form
    {
        private static ProductosPorProveedor frmInstance = null;
        ProductosNegocio productosNegocio = new ProductosNegocio();
        ProveedoresNegocio proveedoresNegocio = new ProveedoresNegocio();
        List<proc_CargarProductosExistBajaPorProveedor_Result> proc_CargarProductosExistBajaPorProveedors;
        List<proc_BuscarProductosPorProveedor_Result> proc_BuscarProductosPorProveedors;
        public static DataTable dtProductosMarcados;
        
        
        
        
        public static ProductosPorProveedor Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ProductosPorProveedor();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public ProductosPorProveedor()
        {
            InitializeComponent();
        }

        private void ProductosPorProveedor_Load(object sender, EventArgs e)
        {
            LlenarTextBox(DetallesOrdenCompra.proveedorID);
            CargarDataGridView();
            InicializarDataTable();
            
        }         
        

        private void InicializarDataTable()
        {
            dtProductosMarcados = new DataTable();
            dtProductosMarcados.Columns.Add("ProductoID", typeof(int));
            dtProductosMarcados.Columns.Add("Referencia", typeof(string));
            dtProductosMarcados.Columns.Add("Descripcion", typeof(string));
            dtProductosMarcados.Columns.Add("Calidad", typeof(string));
            dtProductosMarcados.Columns.Add("Existencia", typeof(double));
            dtProductosMarcados.Columns.Add("Cant Min", typeof(double));
            dtProductosMarcados.Columns.Add("Ordenada", typeof(double));
            dtProductosMarcados.Columns.Add("Precio Compra", typeof(decimal));
        }

        private void CargarDataGridView()
        {
            if (cbProdExistBaja.Checked == true)
            {
                proc_CargarProductosExistBajaPorProveedors = productosNegocio.CargarProductosExistBajaPorProveedor(DetallesOrdenCompra.proveedorID).ToList();
                dgvProductos.DataSource = proc_CargarProductosExistBajaPorProveedors;
            } else
            {
                proc_BuscarProductosPorProveedors = productosNegocio.BuscarProductosPorProveedor(DetallesOrdenCompra.proveedorID).ToList();
                dgvProductos.DataSource = proc_BuscarProductosPorProveedors;
            }
        }

        private void LlenarTextBox(int proveedorID)
        {
            var result = proveedoresNegocio.BuscarProveedoresPorID(proveedorID).FirstOrDefault();
            txtCodProveedor.Text = proveedorID.ToString();
            txtNomProveedor.Text = result.Nombre;
        }

      

        private void cbProdExistBaja_CheckedChanged(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if ((dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Selected))
            {
                if (Convert.ToBoolean(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value) == true)
                    dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value = false;
                else
                    dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value = true;
            }
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Selected = true;
        }

        private void btnDesmarcarTodo_Click(object sender, EventArgs e)
        {
            MarcarODesmarcarTodo(false);
        }

        private void btnMarcarTodo_Click(object sender, EventArgs e)
        {
            MarcarODesmarcarTodo(true);
        }

        private void MarcarODesmarcarTodo(bool valor)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
                row.Cells[0].Value = valor;

            dgvProductos.RefreshEdit();

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProductosMarcados();
            DetallesOrdenCompra.verificarSeleccionProducto = true;
            this.Close();
        }

        private void ProductosMarcados()
        {
            foreach (DataGridViewRow rowMarcados in dgvProductos.Rows)
            {
                if (Convert.ToBoolean(rowMarcados.Cells[0].Value) == true)
                {
                    dtProductosMarcados.Rows.Add(Convert.ToInt32(rowMarcados.Cells[1].Value)
                        ,Convert.ToString(rowMarcados.Cells[2].Value)
                        ,Convert.ToString(rowMarcados.Cells[3].Value)
                        ,Convert.ToString(rowMarcados.Cells[4].Value)
                        ,Convert.ToDouble(rowMarcados.Cells[5].Value)
                        ,Convert.ToDouble(rowMarcados.Cells[6].Value)
                        ,Convert.ToDouble(rowMarcados.Cells[7].Value)
                        ,Convert.ToDecimal(rowMarcados.Cells[8].Value));
                
                } 
                
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbProdExistBaja.Checked == true)
            {
                FiltrarProductosBajaExist();
            }
            else
            {
                FiltrarProductosPorProveedor();
            }
               
        }

        private void FiltrarProductosBajaExist()
        {
            if (rbtnCodigo.Checked == true)
                dgvProductos.DataSource = proc_CargarProductosExistBajaPorProveedors.Where(p => p.ProductoID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnReferencia.Checked == true)
                dgvProductos.DataSource = proc_CargarProductosExistBajaPorProveedors.Where(p => p.Referencia.Contains(txtBuscar.Text)).ToList();
            if (rbtnDescripcion.Checked == true)
                dgvProductos.DataSource = proc_CargarProductosExistBajaPorProveedors.Where(p => p.Descripcion.Contains(txtBuscar.Text)).ToList();
        }

        private void FiltrarProductosPorProveedor()
        {
            if (rbtnCodigo.Checked == true)
                dgvProductos.DataSource = proc_BuscarProductosPorProveedors.Where(p => p.ProductoID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnReferencia.Checked == true)
                dgvProductos.DataSource = proc_BuscarProductosPorProveedors.Where(p => p.Referencia.Contains(txtBuscar.Text)).ToList();
            if (rbtnDescripcion.Checked == true)
                dgvProductos.DataSource = proc_BuscarProductosPorProveedors.Where(p => p.Descripcion.Contains(txtBuscar.Text)).ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
