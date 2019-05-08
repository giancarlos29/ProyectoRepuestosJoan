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
    public partial class BuscarProductos : Form
    {
        private static BuscarProductos frmInstance = null;
        ProductosNegocio productosNegocio = new ProductosNegocio();
        List<proc_CargarTodosProductos_Result> proc_CargarTodosProductos_Results;
        public static int productoID;
        Producto productoEntidad = new Producto();
        public static bool verificar = false;

        public static BuscarProductos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new BuscarProductos();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }


        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {

            CargarDataGridView();            
        }

        private void CargarDataGridView()
        {
            proc_CargarTodosProductos_Results = productosNegocio.CargarTodosProductos().ToList();
            dgvProductos.DataSource = proc_CargarTodosProductos_Results;    

        }

        private void AlertaStock()
        {
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (Convert.ToDouble(fila.Cells[4].Value) <= Convert.ToDouble(fila.Cells[13].Value))
                {
                    fila.Cells[4].Style.BackColor = System.Drawing.Color.Orange;
                }
                if (Convert.ToDouble(fila.Cells[4].Value) == 0)
                {
                    fila.Cells[4].Style.BackColor = System.Drawing.Color.Red;
                }
                if (Convert.ToDouble(fila.Cells[4].Value) > Convert.ToDouble(fila.Cells[14].Value))
                {
                    fila.Cells[4].Style.BackColor = System.Drawing.Color.Green;
                }

            }
        }
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            productoID = (int)dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value;

            EditarProducto editarProducto = null;
            editarProducto = EditarProducto.Instance();           
            editarProducto.ShowDialog();
            dgvProductos.RefreshEdit();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCodigo.Checked == true)
                dgvProductos.DataSource = proc_CargarTodosProductos_Results.Where(p => p.ProductoID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnReferencia.Checked == true)
                dgvProductos.DataSource = proc_CargarTodosProductos_Results.Where(p => p.Referencia.Contains(txtBuscar.Text)).ToList();
            if (rbtnProveedor.Checked == true)
                dgvProductos.DataSource = proc_CargarTodosProductos_Results.Where(p => p.Nombre.Contains(txtBuscar.Text)).ToList();
            if (rbtnDescripcion.Checked == true)
                dgvProductos.DataSource = proc_CargarTodosProductos_Results.Where(p => p.Descripcion.Contains(txtBuscar.Text)).ToList();

            AlertaStock();
        }

        private void BuscarProductos_Activated(object sender, EventArgs e)
        {
            if (verificar)
            {
                CargarDataGridView();
                AlertaStock();
                verificar = false;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = null;
            agregarProducto = AgregarProducto.Instance();
            agregarProducto.MdiParent = this.MdiParent;
            agregarProducto.Show();
            this.Close();
        }

        private void BuscarProductos_Shown(object sender, EventArgs e)
        {
            AlertaStock();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Selected = true;
        }
    }
}
