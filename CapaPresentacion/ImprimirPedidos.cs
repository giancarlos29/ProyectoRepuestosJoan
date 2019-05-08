using CapaNegocios;
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

namespace CapaPresentacion
{
    public partial class ImprimirPedidos : Form
    {
        private static ImprimirPedidos frmInstance = null;
        ReportParameter[] parameters = new ReportParameter[2];
        OrdenesCompraNegocio ordenesCompraNegocio = new OrdenesCompraNegocio();


        public static ImprimirPedidos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirPedidos();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ImprimirPedidos()
        {
            InitializeComponent();
        }

        private void reporte1_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirPedidos_Load(object sender, EventArgs e)
        {
            CargarParametros();
            CargarPedidosRV();
            
        }
        
        private void CargarParametros()
        {
            parameters[0] = new ReportParameter("fInicial", RangoFechaPedidosProveedor.fInicial.ToShortDateString());
            parameters[1] = new ReportParameter("fFinal", RangoFechaPedidosProveedor.fFinal.ToShortDateString());

        }

        private void CargarPedidosRV()
        {
            var dataSource = new ReportDataSource("DataSetOrdenesCompraPFecha", ordenesCompraNegocio.CargarOrdenesCompraPFecha(RangoFechaPedidosProveedor.fInicial.Date,RangoFechaPedidosProveedor.fFinal.Date).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirPedidos.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.LocalReport.DataSources.Add(dataSource);
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }

    }
}
