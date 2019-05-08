using Microsoft.Reporting.WinForms;
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
    public partial class ImprimirGanancias : Form
    {
        private static ImprimirGanancias frmInstance = null;
        ReportParameter[] parameters = new ReportParameter[9];
        FacturasNegocio facturasNegocio = new FacturasNegocio();


        public static ImprimirGanancias Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirGanancias();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ImprimirGanancias()
        {
            InitializeComponent();
        }

        private void ImprimirGanancias_Load(object sender, EventArgs e)
        {
            CargarParametros();            
            CargarPedidosRV();

        }      

        private void CargarParametros()
        {
            var result = facturasNegocio.CalcularGanancias();
            parameters[0] = new ReportParameter("gananciasContDia", result.Item1.ToString());
            parameters[1] = new ReportParameter("gananciasContSemana", result.Item2.ToString());
            parameters[2] = new ReportParameter("gananciasContMes", result.Item3.ToString());
            parameters[3] = new ReportParameter("gananciasCredDia", result.Item4.ToString());
            parameters[4] = new ReportParameter("gananciasCredSemana", result.Item5.ToString());
            parameters[5] = new ReportParameter("gananciasCredMes", result.Item6.ToString());
            parameters[6] = new ReportParameter("fDia", DateTime.Today.Date.ToString());
            parameters[7] = new ReportParameter("fSemana", DateTime.Today.AddDays(-7).ToString());
            parameters[8] = new ReportParameter("fMes", DateTime.Today.AddDays(-30).ToString());
        }


        private void CargarPedidosRV()
        {
            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirGanancias.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }

    }
}
