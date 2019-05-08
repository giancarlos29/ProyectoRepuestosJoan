namespace CapaPresentacion
{
    partial class ImprimirPedidos
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
            this.reporte1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proc_CargarOrdenesCompraPFecha_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarOrdenesCompraPFecha_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte1
            // 
            this.reporte1.AutoSize = true;
            this.reporte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reporte1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reporte1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSetOrdenesCompraPFecha";
            reportDataSource1.Value = this.proc_CargarOrdenesCompraPFecha_ResultBindingSource;
            this.reporte1.LocalReport.DataSources.Add(reportDataSource1);
            this.reporte1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.imprimirPedidos.rdlc";
            this.reporte1.Location = new System.Drawing.Point(0, 0);
            this.reporte1.Margin = new System.Windows.Forms.Padding(0);
            this.reporte1.Name = "reporte1";
            this.reporte1.ServerReport.BearerToken = null;
            this.reporte1.Size = new System.Drawing.Size(1200, 692);
            this.reporte1.TabIndex = 3;
            this.reporte1.Load += new System.EventHandler(this.reporte1_Load);
            // 
            // proc_CargarOrdenesCompraPFecha_ResultBindingSource
            // 
            this.proc_CargarOrdenesCompraPFecha_ResultBindingSource.DataSource = typeof(CapaDatos.proc_CargarOrdenesCompraPFecha_Result);
            // 
            // ImprimirPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.reporte1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImprimirPedidos";
            this.Text = "ImprimirPedidos";
            this.Load += new System.EventHandler(this.ImprimirPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarOrdenesCompraPFecha_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte1;
        private System.Windows.Forms.BindingSource proc_CargarOrdenesCompraPFecha_ResultBindingSource;
    }
}