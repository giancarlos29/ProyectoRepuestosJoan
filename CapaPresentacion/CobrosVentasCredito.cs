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
    public partial class CobrosVentasCredito : Form
    {
        List<proc_CargarCobrosVentaCredito_Result> proc_CargarCobrosVentaCredito_Results;
        private static CobrosVentasCredito frmInstance = null;
        CobrosVentaCreditoNegocio cobrosVentaCreditoNegocio = new CobrosVentaCreditoNegocio();

        public static CobrosVentasCredito Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new CobrosVentasCredito();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public CobrosVentasCredito()
        {
            InitializeComponent();
        }

        private void CobrosVentasCredito_Load(object sender, EventArgs e)
        {
            CargarTextBox();
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            proc_CargarCobrosVentaCredito_Results = cobrosVentaCreditoNegocio.CargarCobrosVentaCredito(LineasCreditoVentas.lineaVentaCreditoID).ToList();
            dgvCobrosVentaCredito.DataSource = proc_CargarCobrosVentaCredito_Results;
        }

        private void CargarTextBox()
        {
            txtLineaCreditoVentaID.Text = Convert.ToString(LineasCreditoVentas.lineaVentaCreditoID);
            txtClienteID.Text = Convert.ToString(LineasCreditoVentas.clienteID);
            txtMontoPendiente.Text = Convert.ToString(LineasCreditoVentas.montoPendiente);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCobrosVentaCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCobrosVentaCredito.Rows[dgvCobrosVentaCredito.CurrentRow.Index].Selected = true;
        }
    }
}
