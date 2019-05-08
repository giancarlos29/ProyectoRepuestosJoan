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
    public partial class ImprimirLCreditoVentasCompletadas : Form
    {
        ReportParameter[] parameters = new ReportParameter[2];
        LineasCreditoVentasNegocio lineasCreditoVentasNegocio = new LineasCreditoVentasNegocio();
        private static ImprimirLCreditoVentasCompletadas frmInstance = null;

        public static ImprimirLCreditoVentasCompletadas Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirLCreditoVentasCompletadas();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }
        public ImprimirLCreditoVentasCompletadas()
        {
            InitializeComponent();
        }

        private void ImprimirLCreditoVentasCompletadas_Load(object sender, EventArgs e)
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
            var dataSource = new ReportDataSource("DataSetLCreditoVentasCompeltadas", lineasCreditoVentasNegocio.CargarLineasCreditoVentasCompletadasPFecha(RangoFechasLCreditoVenta.fInicial.Date, RangoFechasLCreditoVenta.fFinal.Date).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirLCreditoVentasCompletadas.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }


    }
}
