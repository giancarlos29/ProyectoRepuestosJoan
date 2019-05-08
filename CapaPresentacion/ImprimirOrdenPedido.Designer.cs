namespace CapaPresentacion
{
    partial class ImprimirOrdenPedido
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
            this.reporte1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proc_CargarDetalleOrdenCompra_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarDetalleOrdenCompra_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte1
            // 
            this.reporte1.AutoSize = true;
            this.reporte1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reporte1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reporte1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte1.DocumentMapWidth = 1;
            this.reporte1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.imprimirOrdenPedido.rdlc";
            this.reporte1.Location = new System.Drawing.Point(0, 0);
            this.reporte1.Margin = new System.Windows.Forms.Padding(0);
            this.reporte1.Name = "reporte1";
            this.reporte1.ServerReport.BearerToken = null;
            this.reporte1.Size = new System.Drawing.Size(772, 483);
            this.reporte1.TabIndex = 2;
            this.reporte1.Load += new System.EventHandler(this.reporte1_Load);
            // 
            // proc_CargarDetalleOrdenCompra_ResultBindingSource
            // 
            this.proc_CargarDetalleOrdenCompra_ResultBindingSource.DataSource = typeof(CapaDatos.proc_CargarDetalleOrdenCompra_Result);
            this.proc_CargarDetalleOrdenCompra_ResultBindingSource.CurrentChanged += new System.EventHandler(this.proc_CargarDetalleOrdenCompra_ResultBindingSource_CurrentChanged);
            // 
            // ImprimirOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 483);
            this.Controls.Add(this.reporte1);
            this.Name = "ImprimirOrdenPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImprimirOrdenPedido";
            this.Load += new System.EventHandler(this.ImprimirOrdenPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proc_CargarDetalleOrdenCompra_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte1;
        private System.Windows.Forms.BindingSource proc_CargarDetalleOrdenCompra_ResultBindingSource;
    }
}