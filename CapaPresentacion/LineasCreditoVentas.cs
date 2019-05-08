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
    public partial class LineasCreditoVentas : Form
    {
        private static LineasCreditoVentas frmInstance = null;
        List<proc_CargarTodasLineasCreditoVentas_Result> proc_CargarTodasLineasCreditoVentas_Results;
        List<proc_CargarTodasLineasCreditoVentasCompletadas_Result> proc_CargarTodasLineasCreditoVentasCompletadas_Results;
        List<proc_CargarTodasLineasCreditoVentasPendientes_Result> proc_CargarTodasLineasCreditoVentasPendientes_Results;
        List<proc_CargarTodasLineasCreditoVentasVencidas30_Result> proc_CargarTodasLineasCreditoVentasVencidas30_Results;
        List<proc_CargarTodasLineasCreditoVentasVencidas60_Result> proc_CargarTodasLineasCreditoVentasVencidas60_Results;
        public static int lineaVentaCreditoID, clienteID;
        public static decimal montoPendiente;
        LineasCreditoVentasNegocio lineasCreditoVentasNegocio = new LineasCreditoVentasNegocio();

        public static LineasCreditoVentas Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new LineasCreditoVentas();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public LineasCreditoVentas()
        {
            InitializeComponent();
        }

        private void LineasCreditoVentas_Load(object sender, EventArgs e)
        {
            CargarLineasPendientes();
        }

        private void rbtnLineasPendiente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLineasPendiente.Checked == true)
                CargarLineasPendientes();

            if (rbtnLineasCompletas.Checked == true)
                CargarLineasCompletas();

            if (rbtnLineasVencidas.Checked == true)
                CargarLineasVencidas();

            if (rbtnTodasLineas.Checked == true)
                CargarTodasLineas();
        }

        private void CargarLineasPendientes()
        {
            proc_CargarTodasLineasCreditoVentasPendientes_Results = lineasCreditoVentasNegocio.CargarTodasLineasCreditoVentasPendientes().ToList();
            dgvLineasVentasCredito.DataSource = proc_CargarTodasLineasCreditoVentasPendientes_Results;
            
        }

        private void CargarLineasCompletas()
        {
            proc_CargarTodasLineasCreditoVentasCompletadas_Results = lineasCreditoVentasNegocio.CargarTodasLineasCreditoVentasCompletadas().ToList();
            dgvLineasVentasCredito.DataSource = proc_CargarTodasLineasCreditoVentasCompletadas_Results;
        }
        private void CargarLineasVencidas()
        {
            proc_CargarTodasLineasCreditoVentasVencidas30_Results = lineasCreditoVentasNegocio.CargarTodasLineasCreditoVentasVencidas30().ToList();
            proc_CargarTodasLineasCreditoVentasVencidas60_Results = lineasCreditoVentasNegocio.CargarTodasLineasCreditoVentasVencidas60().ToList();
            foreach (proc_CargarTodasLineasCreditoVentasVencidas30_Result list in proc_CargarTodasLineasCreditoVentasVencidas30_Results)
            {
                dgvLineasVentasCredito.Rows.Add(list.LineaCreditoVentaID,list.FacturaID,list.MontoFactura,list.MontoPendiente,list.Estatus);
            }
            foreach (proc_CargarTodasLineasCreditoVentasVencidas60_Result list in proc_CargarTodasLineasCreditoVentasVencidas60_Results)
            {
                dgvLineasVentasCredito.Rows.Add(list.LineaCreditoVentaID, list.FacturaID, list.MontoFactura, list.MontoPendiente, list.Estatus);
            }

        }
        private void CargarTodasLineas()
        {
            proc_CargarTodasLineasCreditoVentas_Results = lineasCreditoVentasNegocio.CargarTodasLineasCreditoVentas().ToList();
            dgvLineasVentasCredito.DataSource = proc_CargarTodasLineasCreditoVentas_Results;
        }

        private void btnRealizarCobro_Click(object sender, EventArgs e)
        {
            if (dgvLineasVentasCredito.Rows.Count != 0)
            {
                CargarVariables();
                InsertarCobroVentaCredito insertarCobroVentaCredito = null;
                insertarCobroVentaCredito = InsertarCobroVentaCredito.Instance();
                insertarCobroVentaCredito.ShowDialog();
                dgvLineasVentasCredito.RefreshEdit();
                
            }
        }

        private void btnHistorialCobros_Click(object sender, EventArgs e)
        {
            if (dgvLineasVentasCredito.Rows.Count != 0)
            {
                CargarVariables();
                CobrosVentasCredito cobrosVentasCredito = null;
                cobrosVentasCredito = CobrosVentasCredito.Instance();
                cobrosVentasCredito.ShowDialog();
                dgvLineasVentasCredito.RefreshEdit();
            }
        }

        private void dgvLineasVentasCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLineasVentasCredito.Rows[dgvLineasVentasCredito.CurrentRow.Index].Selected = true;
            if(Convert.ToDecimal(dgvLineasVentasCredito.Rows[dgvLineasVentasCredito.CurrentRow.Index].Cells[5].Value) == 0)
            {
                btnRealizarCobro.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarVariables()
        {
                lineaVentaCreditoID = Convert.ToInt32(dgvLineasVentasCredito.Rows[dgvLineasVentasCredito.CurrentRow.Index].Cells[0].Value);
                clienteID = Convert.ToInt32(dgvLineasVentasCredito.Rows[dgvLineasVentasCredito.CurrentRow.Index].Cells[6].Value);
                montoPendiente = Convert.ToInt32(dgvLineasVentasCredito.Rows[dgvLineasVentasCredito.CurrentRow.Index].Cells[5].Value);            
        }
    }
}
