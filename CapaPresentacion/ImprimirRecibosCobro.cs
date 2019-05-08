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
    public partial class ImprimirRecibosCobro : Form
    {
        private static ImprimirRecibosCobro frmInstance = null;
        ReportParameter[] parameters = new ReportParameter[2];
        CobrosVentaCreditoNegocio cobrosVentaCreditoNegocio = new CobrosVentaCreditoNegocio();

        public static ImprimirRecibosCobro Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirRecibosCobro();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ImprimirRecibosCobro()
        {
            InitializeComponent();
        }

        private void ImprimirRecibosCobro_Load(object sender, EventArgs e)
        {
            CargarParametros();
            CargarRecibosCobroRV();

        }

        private void CargarParametros()
        {
            parameters[0] = new ReportParameter("fInicial", RangoFechaPedidosProveedor.fInicial.ToShortDateString());
            parameters[1] = new ReportParameter("fFinal", RangoFechaPedidosProveedor.fFinal.ToShortDateString());

        }

        private void CargarRecibosCobroRV()
        {
            var dataSource = new ReportDataSource("DataSetCobrosVentaCreditoPFecha", cobrosVentaCreditoNegocio.CargarCobrosVentaCreditoPFecha(RangoFechaRecibosCobro.fInicial.Date, RangoFechaRecibosCobro.fFinal.Date).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirRecibosCobro.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.LocalReport.DataSources.Add(dataSource);
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }
    }
}
