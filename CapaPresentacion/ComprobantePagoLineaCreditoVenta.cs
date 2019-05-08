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
    public partial class ComprobantePagoLineaCreditoVenta : Form
    {
        private static ComprobantePagoLineaCreditoVenta frmInstance = null;
        CobrosVentaCreditoNegocio cobrosVentaCreditoNegocio = new CobrosVentaCreditoNegocio();
        

        public static ComprobantePagoLineaCreditoVenta Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ComprobantePagoLineaCreditoVenta();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public ComprobantePagoLineaCreditoVenta()
        {
            InitializeComponent();
        }

        private void ComprobantePagoLineaCreditoVenta_Load(object sender, EventArgs e)
        {
            CargarRV();
            ImprimirReporte();
            this.Close();

        }
        private void CargarRV()
        {            
            var dataSource = new ReportDataSource("DSComprobantePagoLineaCreditoVenta",cobrosVentaCreditoNegocio.ComprobantePagoLineaCreditoVenta().ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../comprobantePagoLineaCreditoVenta.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.LocalReport.DataSources.Add(dataSource);
            reporte1.ZoomMode = ZoomMode.PageWidth;            
            reporte1.RefreshReport();
        }

        private void ImprimirReporte()
        {
            ControladorImpresion objImpresion = new ControladorImpresion();
            objImpresion.Imprimir(reporte1.LocalReport);
        }
    }
}
