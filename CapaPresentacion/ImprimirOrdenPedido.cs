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
    public partial class ImprimirOrdenPedido : Form
    {
        private static ImprimirOrdenPedido frmInstance = null;
        ReportParameter[] parameters = new ReportParameter[3];
        DetalleOrdenCompraNegocio detalleOrdenCompraNegocio = new DetalleOrdenCompraNegocio();


        public static ImprimirOrdenPedido Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ImprimirOrdenPedido();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ImprimirOrdenPedido()
        {
            InitializeComponent();
        }

        private void ImprimirOrdenPedido_Load(object sender, EventArgs e)
        {
            CargarParametros();
            CargarPedidosRV();

        }

        private void CargarParametros()
        {
            parameters[0] = new ReportParameter("numero",Convert.ToString(OrdenesCompras.ordenCompraID));
            parameters[1] = new ReportParameter("fPedido", OrdenesCompras.fPedido.ToShortDateString());
            parameters[2] = new ReportParameter("proveedorID", Convert.ToString(OrdenesCompras.proveedorID));           

        }

        private void CargarPedidosRV()
        {
            var dataSource = new ReportDataSource("DataSetDetalleOrdenCompra", detalleOrdenCompraNegocio.CargarDetalleOrdenCompra(OrdenesCompras.ordenCompraID).ToList());

            reporte1.ProcessingMode = ProcessingMode.Local;
            reporte1.LocalReport.ReportPath = @"../../imprimirOrdenPedido.rdlc";
            reporte1.LocalReport.DataSources.Clear();
            reporte1.LocalReport.DataSources.Add(dataSource);
            reporte1.ZoomMode = ZoomMode.PageWidth;
            reporte1.LocalReport.SetParameters(parameters);
            reporte1.RefreshReport();
        }

        private void reporte1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void proc_CargarDetalleOrdenCompra_ResultBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
