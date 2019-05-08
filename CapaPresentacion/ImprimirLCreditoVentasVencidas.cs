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
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class ImprimirLCreditoVentasVencidas : Form
    {
        private static ImprimirLCreditoVentasVencidas frmInstance = null;
        ReportParameter[] parameters = new ReportParameter[2];
        LineasCreditoVentasNegocio lineasCreditoVentasNegocio = new LineasCreditoVentasNegocio();

        public static ImprimirLCreditoVentasVencidas Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirLCreditoVentasVencidas();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ImprimirLCreditoVentasVencidas()
        {
            InitializeComponent();
        }

        private void ImprimirLCreditoVentasVencidas_Load(object sender, EventArgs e)
        {
            CargarParametros();
            CargarLCVentasRV();

        }

        private void CargarParametros()
        {
            parameters[0] = new ReportParameter("fInicial", RangoFechasLCreditoVenta.fInicial.ToShortDateString());
            parameters[1] = new ReportParameter("fFinal", RangoFechasLCreditoVenta.fFinal.ToShortDateString());
        }


        private void CargarLCVentasRV()
        {
            var dataSource = new ReportDataSource("DataSetLCreditoVentasVencidas", lineasCreditoVentasNegocio.CargarLineasCreditoVentasVencidas30PFecha(RangoFechasLCreditoVenta.fInicial.Date, RangoFechasLCreditoVenta.fFinal.Date).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirLCreditoVentasVencidas.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }

    }
}
