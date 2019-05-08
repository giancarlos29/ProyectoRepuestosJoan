namespace CapaPresentacion
{
    partial class ImprimirLCreditoVentasPendiente
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
            this.reporte1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporte1
            // 
            this.reporte1.AutoSize = true;
            this.reporte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reporte1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reporte1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte1.DocumentMapWidth = 1;
            this.reporte1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.imprimirLCreditoVentasPendiente.rdlc";
            this.reporte1.Location = new System.Drawing.Point(0, 0);
            this.reporte1.Margin = new System.Windows.Forms.Padding(0);
            this.reporte1.Name = "reporte1";
            this.reporte1.ServerReport.BearerToken = null;
            this.reporte1.Size = new System.Drawing.Size(800, 450);
            this.reporte1.TabIndex = 4;
            // 
            // ImprimirLCreditoVentasPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporte1);
            this.Name = "ImprimirLCreditoVentasPendiente";
            this.Text = "ImprimirLCreditoVentasPendiente";
            this.Load += new System.EventHandler(this.ImprimirLCreditoVentasPendiente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte1;
    }
}