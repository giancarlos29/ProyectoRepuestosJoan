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
    public partial class ProductosExistBaja : Form
    {
        
        private static ProductosExistBaja frmInstance = null;
        ProductosNegocio productosNegocio = new ProductosNegocio();
        List<proc_CargarProductosExistBaja_Result> proc_CargarProductosExistBaja;

        public static ProductosExistBaja Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ProductosExistBaja();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }


        public ProductosExistBaja()
        {
            InitializeComponent();
        }

        private void ProductosExistBaja_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
            
        }       

        private void CargarDataGridView()
        {

            proc_CargarProductosExistBaja = productosNegocio.CargarProductosExistBaja().ToList();
            dgvProdExistBaja.DataSource = proc_CargarProductosExistBaja;
        }
          
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCodigo.Checked == true)
                dgvProdExistBaja.DataSource = proc_CargarProductosExistBaja.Where(p => p.ProductoID.ToString().Contains(txtBuscar.Text)).ToList();
            if (rbtnReferencia.Checked == true)
                dgvProdExistBaja.DataSource = proc_CargarProductosExistBaja.Where(p => p.Referencia.Contains(txtBuscar.Text)).ToList();
            if (rbtnDescripcion.Checked == true)
                dgvProdExistBaja.DataSource = proc_CargarProductosExistBaja.Where(p => p.Descripcion.Contains(txtBuscar.Text)).ToList();
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProdExistBaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProdExistBaja.Rows[dgvProdExistBaja.CurrentRow.Index].Selected = true;
        }
    }
}
