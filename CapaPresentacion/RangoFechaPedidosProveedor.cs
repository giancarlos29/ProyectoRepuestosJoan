using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RangoFechaPedidosProveedor : Form
    {
        private static RangoFechaPedidosProveedor frmInstance = null;
        private int result;
        public static DateTime fInicial, fFinal;

        public static RangoFechaPedidosProveedor Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RangoFechaPedidosProveedor();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }


        public RangoFechaPedidosProveedor()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ComprararFechas())
            {
                CargarVariables();                
                AbrirImprimirPedidos();
                this.Close();
            }
        }

        private void CargarVariables()
        {
            fInicial = dTPInicial.Value;
            fFinal = dTPFinal.Value;
        }

        private void AbrirImprimirPedidos()
        {
            ImprimirPedidos imprimirPedidos = null;
            imprimirPedidos = ImprimirPedidos.Instance();
            imprimirPedidos.MdiParent = this.MdiParent;
            imprimirPedidos.Show();
        }

        private void RangoFechaPedidosProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ComprararFechas()
        {
            result = DateTime.Compare(dTPInicial.Value, dTPFinal.Value);
            if(result > 0)
            return false;

            return true;
            
        }
    }
}
