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
    public partial class ImprimirNotasDeCreditoPFecha : Form
    {
        ReportParameter[] parameters = new ReportParameter[2];
        NotasDeCreditoNegocio notasDeCreditoNegocio = new NotasDeCreditoNegocio();
        private static ImprimirNotasDeCreditoPFecha frmInstance = null;

        public static ImprimirNotasDeCreditoPFecha Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirNotasDeCreditoPFecha();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ImprimirNotasDeCreditoPFecha()
        {
            InitializeComponent();
        }

        private void ImprimirNotasDeCreditoPFecha_Load(object sender, EventArgs e)
        {
            CargarParametros();
            CargarNotasDeCreditoV();

        }

        private void CargarParametros()
        {
            parameters[0] = new ReportParameter("fInicial", RangoFechaNotasCreditoPFecha.fInicial.ToShortDateString());
            parameters[1] = new ReportParameter("fFinal", RangoFechaNotasCreditoPFecha.fFinal.ToShortDateString());
        }


        private void CargarNotasDeCreditoV()
        {
            var dataSource = new ReportDataSource("DataSetNotasDeCreditoPFecha", notasDeCreditoNegocio.CargarNotasDeCreditoPFecha(RangoFechaNotasCreditoPFecha.fInicial.Date, RangoFechaNotasCreditoPFecha.fFinal.Date).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirNotasDeCreditoPFecha.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }

    }
}
