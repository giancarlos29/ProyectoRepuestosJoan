namespace CapaPresentacion
{
    partial class NotaDeCredito
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacturaID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVPendienteFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoFactura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProductosDevolver = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorAAplicar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantProdDevueltos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBFacturasPendientes = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "";
            this.btnCancelar.AccessibleName = "";
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.iconlogout;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(370, 289);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 48);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleDescription = "";
            this.btnGuardar.AccessibleName = "";
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.download;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(86, 289);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 48);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtClienteNombre);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(223, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(351, 65);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtClienteNombre.Location = new System.Drawing.Point(90, 28);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.ReadOnly = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(247, 26);
            this.txtClienteNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 39;
            this.label2.Tag = "# Cliente:";
            this.label2.Text = "# Cliente:";
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(103, 42);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteID.MaxLength = 9;
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(72, 20);
            this.txtClienteID.TabIndex = 38;
            this.txtClienteID.TextChanged += new System.EventHandler(this.txtClienteID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 41;
            this.label3.Tag = "# Cliente:";
            this.label3.Text = "# Factura:";
            // 
            // txtFacturaID
            // 
            this.txtFacturaID.Location = new System.Drawing.Point(103, 83);
            this.txtFacturaID.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacturaID.MaxLength = 9;
            this.txtFacturaID.Name = "txtFacturaID";
            this.txtFacturaID.Size = new System.Drawing.Size(72, 20);
            this.txtFacturaID.TabIndex = 40;
            this.txtFacturaID.TextChanged += new System.EventHandler(this.txtFacturaID_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFechaFactura);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVPendienteFactura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMontoFactura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(223, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(351, 127);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fecha Factura:";
            // 
            // txtFechaFactura
            // 
            this.txtFechaFactura.BackColor = System.Drawing.SystemColors.Info;
            this.txtFechaFactura.Location = new System.Drawing.Point(141, 26);
            this.txtFechaFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaFactura.Name = "txtFechaFactura";
            this.txtFechaFactura.ReadOnly = true;
            this.txtFechaFactura.Size = new System.Drawing.Size(196, 26);
            this.txtFechaFactura.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Valor Pendiente:";
            // 
            // txtVPendienteFactura
            // 
            this.txtVPendienteFactura.BackColor = System.Drawing.SystemColors.Info;
            this.txtVPendienteFactura.Location = new System.Drawing.Point(164, 92);
            this.txtVPendienteFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtVPendienteFactura.Name = "txtVPendienteFactura";
            this.txtVPendienteFactura.ReadOnly = true;
            this.txtVPendienteFactura.Size = new System.Drawing.Size(173, 26);
            this.txtVPendienteFactura.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Monto:";
            // 
            // txtMontoFactura
            // 
            this.txtMontoFactura.BackColor = System.Drawing.SystemColors.Info;
            this.txtMontoFactura.Location = new System.Drawing.Point(74, 60);
            this.txtMontoFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoFactura.Name = "txtMontoFactura";
            this.txtMontoFactura.ReadOnly = true;
            this.txtMontoFactura.Size = new System.Drawing.Size(176, 26);
            this.txtMontoFactura.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "";
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(179, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 43;
            this.button1.Text = ".";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProductosDevolver
            // 
            this.btnProductosDevolver.AccessibleDescription = "";
            this.btnProductosDevolver.AccessibleName = "";
            this.btnProductosDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductosDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductosDevolver.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosDevolver.Image = global::CapaPresentacion.Properties.Resources.retouren;
            this.btnProductosDevolver.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnProductosDevolver.Location = new System.Drawing.Point(11, 164);
            this.btnProductosDevolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductosDevolver.Name = "btnProductosDevolver";
            this.btnProductosDevolver.Size = new System.Drawing.Size(205, 37);
            this.btnProductosDevolver.TabIndex = 47;
            this.btnProductosDevolver.Text = "Productos";
            this.btnProductosDevolver.UseVisualStyleBackColor = true;
            this.btnProductosDevolver.Click += new System.EventHandler(this.btnProductosDevolver_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Info;
            this.txtValor.Location = new System.Drawing.Point(94, 212);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(115, 20);
            this.txtValor.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 41);
            this.label6.TabIndex = 51;
            this.label6.Text = "Valor a aplicar:";
            // 
            // txtValorAAplicar
            // 
            this.txtValorAAplicar.Location = new System.Drawing.Point(94, 257);
            this.txtValorAAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorAAplicar.Name = "txtValorAAplicar";
            this.txtValorAAplicar.Size = new System.Drawing.Size(115, 20);
            this.txtValorAAplicar.TabIndex = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantProdDevueltos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(223, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(351, 66);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de productos devueltos";
            // 
            // txtCantProdDevueltos
            // 
            this.txtCantProdDevueltos.BackColor = System.Drawing.SystemColors.Info;
            this.txtCantProdDevueltos.Location = new System.Drawing.Point(141, 28);
            this.txtCantProdDevueltos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantProdDevueltos.Name = "txtCantProdDevueltos";
            this.txtCantProdDevueltos.ReadOnly = true;
            this.txtCantProdDevueltos.Size = new System.Drawing.Size(88, 26);
            this.txtCantProdDevueltos.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 42);
            this.label7.TabIndex = 54;
            this.label7.Tag = "# Cliente:";
            this.label7.Text = "# Factura a aplicar:";
            // 
            // CBFacturasPendientes
            // 
            this.CBFacturasPendientes.BackColor = System.Drawing.SystemColors.Control;
            this.CBFacturasPendientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFacturasPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFacturasPendientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBFacturasPendientes.FormattingEnabled = true;
            this.CBFacturasPendientes.Location = new System.Drawing.Point(103, 123);
            this.CBFacturasPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.CBFacturasPendientes.Name = "CBFacturasPendientes";
            this.CBFacturasPendientes.Size = new System.Drawing.Size(106, 26);
            this.CBFacturasPendientes.TabIndex = 55;
            this.CBFacturasPendientes.SelectedIndexChanged += new System.EventHandler(this.CBFacturasPendientes_SelectedIndexChanged);
            // 
            // NotaDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(585, 346);
            this.Controls.Add(this.CBFacturasPendientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorAAplicar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnProductosDevolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFacturaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.MaximizeBox = false;
            this.Name = "NotaDeCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotaDeCredito";
            this.Load += new System.EventHandler(this.NotaDeCredito_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFacturaID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVPendienteFactura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProductosDevolver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorAAplicar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantProdDevueltos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBFacturasPendientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaFactura;
    }
}