namespace CapaPresentacion
{
    partial class ReporteDetalleFacturaFiscal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportDetalleFFiscal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proc_CargarFacturaVentaCFiscal_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarFacturaVentaCFiscal_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDetalleFFiscal
            // 
            this.reportDetalleFFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFacturaDetalleFiscal";
            reportDataSource1.Value = this.proc_CargarFacturaVentaCFiscal_ResultBindingSource;
            this.reportDetalleFFiscal.LocalReport.DataSources.Add(reportDataSource1);
            this.reportDetalleFFiscal.LocalReport.ReportEmbeddedResource = "CapaPresentacion.reporteDetalleFacturaVentaFiscal.rdlc";
            this.reportDetalleFFiscal.Location = new System.Drawing.Point(0, 0);
            this.reportDetalleFFiscal.Name = "reportDetalleFFiscal";
            this.reportDetalleFFiscal.ServerReport.BearerToken = null;
            this.reportDetalleFFiscal.Size = new System.Drawing.Size(323, 473);
            this.reportDetalleFFiscal.TabIndex = 0;
            this.reportDetalleFFiscal.Load += new System.EventHandler(this.reportDetalleFFiscal_Load);
            // 
            // proc_CargarFacturaVentaCFiscal_ResultBindingSource
            // 
            this.proc_CargarFacturaVentaCFiscal_ResultBindingSource.DataSource = typeof(CapaDatos.proc_CargarFacturaVentaCFiscal_Result);
            // 
            // ReporteDetalleFacturaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 473);
            this.Controls.Add(this.reportDetalleFFiscal);
            this.Name = "ReporteDetalleFacturaFiscal";
            this.Text = "ReporteDetalleFacturaFiscal";
            this.Load += new System.EventHandler(this.ReporteDetalleFacturaFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarFacturaVentaCFiscal_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportDetalleFFiscal;
        private System.Windows.Forms.BindingSource proc_CargarFacturaVentaCFiscal_ResultBindingSource;
    }
}