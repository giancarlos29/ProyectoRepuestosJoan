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
    public partial class ReporteDetalleFacturaFiscal : Form
    {
        private static ReporteDetalleFacturaFiscal frmInstance = null;
        FacturasNegocio facturasNegocio = new FacturasNegocio();

        public static ReporteDetalleFacturaFiscal Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ReporteDetalleFacturaFiscal();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ReporteDetalleFacturaFiscal()
        {
            InitializeComponent();
        }

        private void ReporteDetalleFacturaFiscal_Load(object sender, EventArgs e)
        {
            VerificarTipoVenta();
            ImprimirReporte();
            Close();

        }

        private void reportDetalleFFiscal_Load(object sender, EventArgs e)
        {

        }

        private void VerificarTipoVenta()
            {
                var result = facturasNegocio.VerTipoPagoUltimaFactura().FirstOrDefault();
                switch (result.TipoPagoID)
                {
                    case 1:
                        CargarReporteVentaContado();
                        break;
                    case 2:
                        CargarReporteVentaContado();
                        break;
                    case 3:
                        CargarReporteVentaCredito();
                        break;
                    case 4:
                        CargarReporteVentaCredito();
                        break;
                }

            }
        

        private void CargarReporteVentaContado()
        {
            var dataSource = new ReportDataSource("DataSetFacturaDetalleFiscal", facturasNegocio.CargarFacturaVentaCFiscal().ToList());

            reportDetalleFFiscal.ProcessingMode = ProcessingMode.Local;
            reportDetalleFFiscal.LocalReport.ReportPath = @"../../reporteDetalleFacturaVentaFiscal.rdlc";
            reportDetalleFFiscal.LocalReport.DataSources.Clear();
            reportDetalleFFiscal.LocalReport.DataSources.Add(dataSource);
            reportDetalleFFiscal.ZoomMode = ZoomMode.PageWidth;
            reportDetalleFFiscal.RefreshReport();
        }
        private void CargarReporteVentaCredito()
        {
            var dataSource = new ReportDataSource("DataSetFacturaDetalleFiscal", facturasNegocio.CargarFacturaVentaCFiscal().ToList());

            reportDetalleFFiscal.ProcessingMode = ProcessingMode.Local;
            reportDetalleFFiscal.LocalReport.ReportPath = @"../../reporteDetalleFacturaVentaFiscalCredito.rdlc";
            reportDetalleFFiscal.LocalReport.DataSources.Clear();
            reportDetalleFFiscal.LocalReport.DataSources.Add(dataSource);
            reportDetalleFFiscal.ZoomMode = ZoomMode.PageWidth;
            reportDetalleFFiscal.RefreshReport();
        }
        private void ImprimirReporte()
        {
            ControladorImpresion objImpresion = new ControladorImpresion();
            objImpresion.Imprimir(reportDetalleFFiscal.LocalReport);
        }
    }
}
