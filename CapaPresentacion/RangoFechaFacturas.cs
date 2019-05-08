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
    public partial class RangoFechaFacturas : Form
    {
        private static RangoFechaFacturas frmInstance = null;
        private int result;
        public static DateTime fInicial, fFinal;
         
        public static RangoFechaFacturas Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RangoFechaFacturas();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ComprararFechas())
            {
                CargarVariables();
                AbrirImprimirFacturasPFecha();
                this.Close();
            }
        }

        public RangoFechaFacturas()
        {             
            InitializeComponent();
        }


        private void CargarVariables()
        {
            fInicial = dTPInicial.Value;
            fFinal = dTPFinal.Value;
        }

        private void AbrirImprimirFacturasPFecha()
        {
            ImprimirFacturasPFecha imprimirFacturasPFecha = null;
            imprimirFacturasPFecha = ImprimirFacturasPFecha.Instance();
            imprimirFacturasPFecha.MdiParent = this.MdiParent;
            imprimirFacturasPFecha.Show();
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
