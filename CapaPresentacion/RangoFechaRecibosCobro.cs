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
    public partial class RangoFechaRecibosCobro : Form
    {
        private static RangoFechaRecibosCobro frmInstance = null;
        private int result;
        public static DateTime fInicial, fFinal;

        public static RangoFechaRecibosCobro Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RangoFechaRecibosCobro();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public RangoFechaRecibosCobro()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ComprararFechas())
            {
                CargarVariables();
                AbrirImprimirRecibosCobro();
                this.Close();
            }
        }
        private void CargarVariables()
        {
            fInicial = dTPInicial.Value;
            fFinal = dTPFinal.Value;
        }

        private void AbrirImprimirRecibosCobro()
        {
            ImprimirRecibosCobro imprimirRecibosCobro = null;
            imprimirRecibosCobro = ImprimirRecibosCobro.Instance();
            imprimirRecibosCobro.MdiParent = this.MdiParent;
            imprimirRecibosCobro.Show();
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
