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
    public partial class RangoFecha10ProdMasVendidos : Form
    {

        private static RangoFecha10ProdMasVendidos frmInstance = null;
        private int result;
        public static DateTime fInicial, fFinal;

        public static RangoFecha10ProdMasVendidos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RangoFecha10ProdMasVendidos();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }


        public RangoFecha10ProdMasVendidos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ComprararFechas())
            {
                CargarVariables();
                AbrirImprimir10ProdMasVendido();
                this.Close();
            }
        }

        private void CargarVariables()
        {
            fInicial = dTPInicial.Value;
            fFinal = dTPFinal.Value;
        }

        private void AbrirImprimir10ProdMasVendido()
        {
            Imprimir10ProdMasVendidos imprimir10ProdMasVendidos = null;
            imprimir10ProdMasVendidos = Imprimir10ProdMasVendidos.Instance();
            imprimir10ProdMasVendidos.MdiParent = this.MdiParent;
            imprimir10ProdMasVendidos.Show();
        }       

        private bool ComprararFechas()
        {
            result = DateTime.Compare(dTPInicial.Value, dTPFinal.Value);
            if (result > 0)
                return false;

            return true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RangoFecha10ProdMasVendidos_Load(object sender, EventArgs e)
        {

        }
    }
}
