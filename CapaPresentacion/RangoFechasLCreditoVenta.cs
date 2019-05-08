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

namespace CapaPresentacion
{
    public partial class RangoFechasLCreditoVenta : Form
    {
        private static RangoFechasLCreditoVenta frmInstance = null;
        private int rbtn;
        private int result;
        public static DateTime fInicial, fFinal;

        public static RangoFechasLCreditoVenta Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RangoFechasLCreditoVenta();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public RangoFechasLCreditoVenta()
        {
            InitializeComponent();
        }

        private void RangoFechasLCreditoVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ComprararFechas())
            {
                CargarVariables();

                switch (rbtn) {
                    case 1:
                        AbrirImprimirLCreditoVentaCompletadas();
                        break;
                    case 2:
                        AbrirImprimirLCreditoVentaPendiente();
                        break;
                    case 3:
                        AbrirImprimirLCreditoVentaVencidas();
                        break;
                }
                this.Close();
            }
        }
        private void CargarVariables()
        {
            fInicial = dTPInicial.Value;
            fFinal = dTPFinal.Value;

            if(rbLCreditoVCompletadas.Checked == true)
            {
                rbtn = 1;
            } else if (rbLCreditoVPendientes.Checked == true)
            {
                rbtn = 2;
            }else if(rbLCreditoVVencidas.Checked == true)
            {
                rbtn = 3;
            }

        }

        private void AbrirImprimirLCreditoVentaCompletadas()
        {
            ImprimirLCreditoVentasCompletadas imprimirLCreditoVentasCompletadas = null;
            imprimirLCreditoVentasCompletadas = ImprimirLCreditoVentasCompletadas.Instance();
            imprimirLCreditoVentasCompletadas.MdiParent = this.MdiParent;
            imprimirLCreditoVentasCompletadas.Show();
        }

        private void AbrirImprimirLCreditoVentaPendiente()
        {
            ImprimirLCreditoVentasPendiente imprimirLCreditoVentasPendiente = null;
            imprimirLCreditoVentasPendiente = ImprimirLCreditoVentasPendiente.Instance();
            imprimirLCreditoVentasPendiente.MdiParent = this.MdiParent;
            imprimirLCreditoVentasPendiente.Show();
        }

        private void AbrirImprimirLCreditoVentaVencidas()
        {
            ImprimirLCreditoVentasVencidas imprimirLCreditoVentasVencidas = null;
            imprimirLCreditoVentasVencidas = ImprimirLCreditoVentasVencidas.Instance();
            imprimirLCreditoVentasVencidas.MdiParent = this.MdiParent;
            imprimirLCreditoVentasVencidas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ComprararFechas()
        {
            result = DateTime.Compare(dTPInicial.Value, dTPFinal.Value);
            if (result > 0)
                return false;

            return true;

        }
    }
}
