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
    public partial class OrdenesCompras : Form
    {
        private static OrdenesCompras frmInstance = null;
        List<proc_CargarTodasOrdenesCompra_Result> proc_CargarTodasOrdenesCompra_Results;
        OrdenesCompraNegocio ordenesCompraNegocio = new OrdenesCompraNegocio();
        public static int ordenCompraID, proveedorID;
        public static DateTime fPedido;
        public static bool verificarCreacionFacturaCompra = false;

        public static OrdenesCompras Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new OrdenesCompras();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public OrdenesCompras()
        {
            InitializeComponent();
        }

        private void OrdenesCompras_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            proc_CargarTodasOrdenesCompra_Results = ordenesCompraNegocio.CargarTodasOrdenesCompra().ToList();
            dgvOrdenesCompra.DataSource = proc_CargarTodasOrdenesCompra_Results;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            BuscarProveedores buscarProveedores = null;
            buscarProveedores = BuscarProveedores.Instance();
            buscarProveedores.MdiParent = this.MdiParent;
            buscarProveedores.Show();
            this.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            CargarVariables();
            FacturarOrdenCompra facturarOrdenCompra = null;
            facturarOrdenCompra = FacturarOrdenCompra.Instance();            
            facturarOrdenCompra.ShowDialog();
            VerificarCreacionFacturaCompra();
        }

        private void VerificarCreacionFacturaCompra()
        {
            if (verificarCreacionFacturaCompra)
            {
                CargarDataGridView();
                verificarCreacionFacturaCompra = false;
            }
        }

        private void CargarVariables()
        {
            ordenCompraID = Convert.ToInt32(dgvOrdenesCompra.Rows[dgvOrdenesCompra.CurrentRow.Index].Cells[0].Value);
            proveedorID = Convert.ToInt32(dgvOrdenesCompra.Rows[dgvOrdenesCompra.CurrentRow.Index].Cells[1].Value);
            fPedido = Convert.ToDateTime(dgvOrdenesCompra.Rows[dgvOrdenesCompra.CurrentRow.Index].Cells[2].Value);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CargarVariables();
            ImprimirOrdenPedido imprimirOrdenPedido = null;
            imprimirOrdenPedido = ImprimirOrdenPedido.Instance();            
            imprimirOrdenPedido.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOrdenesCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrdenesCompra.Rows[dgvOrdenesCompra.CurrentRow.Index].Selected = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarVariables();
            DetallesOrdenCompra.abiertoDesdeOrdenesCompraForm = true;
            DetallesOrdenCompra detallesOrdenCompra = null;
            detallesOrdenCompra = DetallesOrdenCompra.Instance();            
            detallesOrdenCompra.ShowDialog();
        }
    }
}
