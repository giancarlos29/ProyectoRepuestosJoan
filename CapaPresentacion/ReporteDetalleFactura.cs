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
using System.Drawing.Printing;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class ReporteDetalleFactura : Form
    {
        private static ReporteDetalleFactura frmInstance = null;
        FacturasNegocio facturasNegocio = new FacturasNegocio();

        public static ReporteDetalleFactura Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ReporteDetalleFactura();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ReporteDetalleFactura()
        {
            InitializeComponent();
        }

        private void ReporteDetalleFactura_Load(object sender, EventArgs e)
        {

          VerificarTipoVenta();
          ImprimirReporte();
          Close();
            
        }

        private void reporDetalleFac_Load(object sender, EventArgs e)
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
           var dataSource = new ReportDataSource("DataSetDetalleFactura", facturasNegocio.CargarFacturaVentaCFinal().ToList());

            reporDetalleFac.ProcessingMode = ProcessingMode.Local;
            reporDetalleFac.LocalReport.ReportPath = @"../../reporteDetalleFacturaVenta.rdlc";
            reporDetalleFac.LocalReport.DataSources.Clear();
            reporDetalleFac.LocalReport.DataSources.Add(dataSource);
            reporDetalleFac.ZoomMode = ZoomMode.PageWidth;
            reporDetalleFac.RefreshReport();
        }

        private void CargarReporteVentaCredito()
        {
            var dataSource = new ReportDataSource("DataSetDetalleFactura", facturasNegocio.CargarFacturaVentaCFinal().ToList());

            reporDetalleFac.ProcessingMode = ProcessingMode.Local;
            reporDetalleFac.LocalReport.ReportPath = @"../../reporteDetalleFacturaVentaCredito.rdlc";
            reporDetalleFac.LocalReport.DataSources.Clear();
            reporDetalleFac.LocalReport.DataSources.Add(dataSource);
            reporDetalleFac.ZoomMode = ZoomMode.PageWidth;
            reporDetalleFac.RefreshReport();
        }

        private void ImprimirReporte()
        {
            ControladorImpresion objImpresion = new ControladorImpresion();
            objImpresion.Imprimir(reporDetalleFac.LocalReport);

        }
    }
}
