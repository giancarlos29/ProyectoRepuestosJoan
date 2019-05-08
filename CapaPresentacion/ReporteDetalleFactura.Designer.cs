namespace CapaPresentacion
{
    partial class ReporteDetalleFactura
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
            this.proc_CargarFacturaVentaCFinal_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporDetalleFac = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarFacturaVentaCFinal_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // proc_CargarFacturaVentaCFinal_ResultBindingSource
            // 
            this.proc_CargarFacturaVentaCFinal_ResultBindingSource.DataSource = typeof(CapaDatos.proc_CargarFacturaVentaCFinal_Result);
            // 
            // reporDetalleFac
            // 
            this.reporDetalleFac.AutoSize = true;
            this.reporDetalleFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reporDetalleFac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reporDetalleFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporDetalleFac.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSetDetalleFactura";
            reportDataSource1.Value = this.proc_CargarFacturaVentaCFinal_ResultBindingSource;
            this.reporDetalleFac.LocalReport.DataSources.Add(reportDataSource1);
            this.reporDetalleFac.LocalReport.ReportEmbeddedResource = "CapaPresentacion.reporteDetalleFacturaVenta.rdlc";
            this.reporDetalleFac.Location = new System.Drawing.Point(0, 0);
            this.reporDetalleFac.Margin = new System.Windows.Forms.Padding(0);
            this.reporDetalleFac.Name = "reporDetalleFac";
            this.reporDetalleFac.ServerReport.BearerToken = null;
            this.reporDetalleFac.Size = new System.Drawing.Size(323, 473);
            this.reporDetalleFac.TabIndex = 0;
            this.reporDetalleFac.Load += new System.EventHandler(this.reporDetalleFac_Load);
            // 
            // ReporteDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 473);
            this.Controls.Add(this.reporDetalleFac);
            this.Name = "ReporteDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteDetalleFactura";
            this.Load += new System.EventHandler(this.ReporteDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarFacturaVentaCFinal_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporDetalleFac;
        private System.Windows.Forms.BindingSource proc_CargarFacturaVentaCFinal_ResultBindingSource;
    }
}