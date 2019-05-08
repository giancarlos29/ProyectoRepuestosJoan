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
    public partial class Imprimir10ProdMasVendidos : Form
    {
        ReportParameter[] parameters = new ReportParameter[2];
        ProductosNegocio productosNegocio = new ProductosNegocio();
        private static Imprimir10ProdMasVendidos frmInstance = null;

        public static Imprimir10ProdMasVendidos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new Imprimir10ProdMasVendidos();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public Imprimir10ProdMasVendidos()
        {
            InitializeComponent();
        }

        private void Imprimir10ProdMasVendidos_Load(object sender, EventArgs e)
        {
            CargarParametros();
            Cargar10ProdMVendRV();

        }

        private void CargarParametros()
        {
            parameters[0] = new ReportParameter("fInicial", RangoFecha10ProdMasVendidos.fInicial.ToShortDateString());
            parameters[1] = new ReportParameter("fFinal", RangoFecha10ProdMasVendidos.fFinal.ToShortDateString());
        }


        private void Cargar10ProdMVendRV()
        {
            var dataSource = new ReportDataSource("DataSet10ProdMasVendidos", productosNegocio.Cargar10ProductosVendidosPFecha(RangoFecha10ProdMasVendidos.fInicial.Date, RangoFecha10ProdMasVendidos.fFinal.Date).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimir10ProdMasVendidos.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }

    }
}
