namespace CapaPresentacion
{
    partial class RangoFechasLCreditoVenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPFinal = new System.Windows.Forms.DateTimePicker();
            this.dTPInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLCreditoVVencidas = new System.Windows.Forms.RadioButton();
            this.rbLCreditoVCompletadas = new System.Windows.Forms.RadioButton();
            this.rbLCreditoVPendientes = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTPFinal);
            this.groupBox1.Controls.Add(this.dTPInicial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio:";
            // 
            // dTPFinal
            // 
            this.dTPFinal.CustomFormat = "dd MMMM yyyy";
            this.dTPFinal.Location = new System.Drawing.Point(34, 117);
            this.dTPFinal.Name = "dTPFinal";
            this.dTPFinal.Size = new System.Drawing.Size(275, 26);
            this.dTPFinal.TabIndex = 1;
            // 
            // dTPInicial
            // 
            this.dTPInicial.Location = new System.Drawing.Point(34, 50);
            this.dTPInicial.Name = "dTPInicial";
            this.dTPInicial.Size = new System.Drawing.Size(275, 26);
            this.dTPInicial.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLCreditoVVencidas);
            this.groupBox2.Controls.Add(this.rbLCreditoVCompletadas);
            this.groupBox2.Controls.Add(this.rbLCreditoVPendientes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Reporte";
            // 
            // rbLCreditoVVencidas
            // 
            this.rbLCreditoVVencidas.AutoSize = true;
            this.rbLCreditoVVencidas.Location = new System.Drawing.Point(13, 107);
            this.rbLCreditoVVencidas.Name = "rbLCreditoVVencidas";
            this.rbLCreditoVVencidas.Size = new System.Drawing.Size(265, 24);
            this.rbLCreditoVVencidas.TabIndex = 2;
            this.rbLCreditoVVencidas.Text = "Lineas de credito ventas vencidas";
            this.rbLCreditoVVencidas.UseVisualStyleBackColor = true;
            // 
            // rbLCreditoVCompletadas
            // 
            this.rbLCreditoVCompletadas.AutoSize = true;
            this.rbLCreditoVCompletadas.Location = new System.Drawing.Point(13, 66);
            this.rbLCreditoVCompletadas.Name = "rbLCreditoVCompletadas";
            this.rbLCreditoVCompletadas.Size = new System.Drawing.Size(294, 24);
            this.rbLCreditoVCompletadas.TabIndex = 1;
            this.rbLCreditoVCompletadas.Text = "Lineas de credito ventas completadas";
            this.rbLCreditoVCompletadas.UseVisualStyleBackColor = true;
            // 
            // rbLCreditoVPendientes
            // 
            this.rbLCreditoVPendientes.AutoSize = true;
            this.rbLCreditoVPendientes.Checked = true;
            this.rbLCreditoVPendientes.Location = new System.Drawing.Point(13, 25);
            this.rbLCreditoVPendientes.Name = "rbLCreditoVPendientes";
            this.rbLCreditoVPendientes.Size = new System.Drawing.Size(282, 24);
            this.rbLCreditoVPendientes.TabIndex = 0;
            this.rbLCreditoVPendientes.TabStop = true;
            this.rbLCreditoVPendientes.Text = "Lineas de credito ventas pendientes";
            this.rbLCreditoVPendientes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleDescription = "";
            this.btnSalir.AccessibleName = "";
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.iconlogout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(383, 167);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 46);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.imprimiricono;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(208, 167);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 46);
            this.btnImprimir.TabIndex = 49;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // RangoFechasLCreditoVenta
            // 
            this.AcceptButton = this.btnImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(699, 218);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "RangoFechasLCreditoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RangoFechasLCreditoVenta";
            this.Load += new System.EventHandler(this.RangoFechasLCreditoVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPFinal;
        private System.Windows.Forms.DateTimePicker dTPInicial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLCreditoVVencidas;
        private System.Windows.Forms.RadioButton rbLCreditoVCompletadas;
        private System.Windows.Forms.RadioButton rbLCreditoVPendientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
    }
}