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
    public partial class RangoFechaNotasCreditoPFecha : Form
    {
        private static RangoFechaNotasCreditoPFecha frmInstance = null;
        private int result;
        public static DateTime fInicial, fFinal;

        public static RangoFechaNotasCreditoPFecha Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RangoFechaNotasCreditoPFecha();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }


        public RangoFechaNotasCreditoPFecha()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ComprararFechas())
            {
                CargarVariables();
                AbrirImprimirNotasDeCreditoPFecha();
                this.Close();
            }
        }

        private void CargarVariables()
        {
            fInicial = dTPInicial.Value;
            fFinal = dTPFinal.Value;
        }

        private void AbrirImprimirNotasDeCreditoPFecha()
        {
            ImprimirNotasDeCreditoPFecha imprimirNotasDeCreditoPFecha = null;
            imprimirNotasDeCreditoPFecha = ImprimirNotasDeCreditoPFecha.Instance();
            imprimirNotasDeCreditoPFecha.MdiParent = this.MdiParent;
            imprimirNotasDeCreditoPFecha.Show();
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
