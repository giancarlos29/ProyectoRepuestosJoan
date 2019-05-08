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
    public partial class ImprimirFacturasPFecha : Form
    {
        
        private static ImprimirFacturasPFecha frmInstance = null;
        ReportParameter[] parameters = new ReportParameter[2];
        FacturasNegocio facturasNegocio = new FacturasNegocio();        



        public static ImprimirFacturasPFecha Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirFacturasPFecha();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ImprimirFacturasPFecha()
        {
            InitializeComponent();
        }

        private void ImprimirFacturasPFecha_Load(object sender, EventArgs e)
        {
            CargarParametros();
            CargarFacturasPFecha();

        }

        private void CargarParametros()
        {
            parameters[0] = new ReportParameter("fInicial", RangoFechaFacturas.fInicial.ToShortDateString());
            parameters[1] = new ReportParameter("fFinal", RangoFechaFacturas.fFinal.ToShortDateString());
        }


        private void CargarFacturasPFecha()
        {
            var dataSource = new ReportDataSource("DataSetFacturasPFecha", facturasNegocio.CargarFacturasPFecha(RangoFechaFacturas.fInicial.Date, RangoFechaFacturas.fFinal.Date).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirFacturasPFecha.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }

    }
}
