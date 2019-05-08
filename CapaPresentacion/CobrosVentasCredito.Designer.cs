namespace CapaPresentacion
{
    partial class CobrosVentasCredito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCobrosVentaCredito = new System.Windows.Forms.DataGridView();
            this.OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLineaCreditoVentaID = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.txtMontoPendiente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosVentaCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCobrosVentaCredito
            // 
            this.dgvCobrosVentaCredito.AllowUserToAddRows = false;
            this.dgvCobrosVentaCredito.AllowUserToDeleteRows = false;
            this.dgvCobrosVentaCredito.AllowUserToResizeRows = false;
            this.dgvCobrosVentaCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobrosVentaCredito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCobrosVentaCredito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobrosVentaCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCobrosVentaCredito.ColumnHeadersHeight = 42;
            this.dgvCobrosVentaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCobrosVentaCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenCompra,
            this.FechaPago,
            this.MontoPago,
            this.FechaPedido,
            this.Concepto});
            this.dgvCobrosVentaCredito.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobrosVentaCredito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCobrosVentaCredito.EnableHeadersVisualStyles = false;
            this.dgvCobrosVentaCredito.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCobrosVentaCredito.Location = new System.Drawing.Point(2, 82);
            this.dgvCobrosVentaCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCobrosVentaCredito.Name = "dgvCobrosVentaCredito";
            this.dgvCobrosVentaCredito.ReadOnly = true;
            this.dgvCobrosVentaCredito.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCobrosVentaCredito.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCobrosVentaCredito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCobrosVentaCredito.Size = new System.Drawing.Size(633, 180);
            this.dgvCobrosVentaCredito.TabIndex = 38;
            this.dgvCobrosVentaCredito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCobrosVentaCredito_CellClick);
            this.dgvCobrosVentaCredito.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.DataPropertyName = "CobroVentaCreditoID";
            this.OrdenCompra.HeaderText = "ID";
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.ReadOnly = true;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaCobro";
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            // 
            // MontoPago
            // 
            this.MontoPago.DataPropertyName = "Monto";
            this.MontoPago.HeaderText = "Monto Pago";
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.ReadOnly = true;
            // 
            // FechaPedido
            // 
            this.FechaPedido.DataPropertyName = "UserID";
            this.FechaPedido.HeaderText = "UserID";
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "LineaCreditoVentaID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "ClienteID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Monto Pendiente:";
            // 
            // txtLineaCreditoVentaID
            // 
            this.txtLineaCreditoVentaID.BackColor = System.Drawing.SystemColors.Info;
            this.txtLineaCreditoVentaID.Location = new System.Drawing.Point(319, 21);
            this.txtLineaCreditoVentaID.Name = "txtLineaCreditoVentaID";
            this.txtLineaCreditoVentaID.ReadOnly = true;
            this.txtLineaCreditoVentaID.Size = new System.Drawing.Size(57, 20);
            this.txtLineaCreditoVentaID.TabIndex = 43;
            // 
            // txtClienteID
            // 
            this.txtClienteID.BackColor = System.Drawing.SystemColors.Info;
            this.txtClienteID.Location = new System.Drawing.Point(108, 51);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.ReadOnly = true;
            this.txtClienteID.Size = new System.Drawing.Size(52, 20);
            this.txtClienteID.TabIndex = 44;
            // 
            // txtMontoPendiente
            // 
            this.txtMontoPendiente.BackColor = System.Drawing.SystemColors.Info;
            this.txtMontoPendiente.Location = new System.Drawing.Point(400, 49);
            this.txtMontoPendiente.Name = "txtMontoPendiente";
            this.txtMontoPendiente.ReadOnly = true;
            this.txtMontoPendiente.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPendiente.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(516, 70);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
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
            this.btnSalir.Location = new System.Drawing.Point(529, 21);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 51);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CobrosVentasCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(638, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtMontoPendiente);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtLineaCreditoVentaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCobrosVentaCredito);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CobrosVentasCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Cobros de Venta a Credito";
            this.Load += new System.EventHandler(this.CobrosVentasCredito_Load);
            this.Click += new System.EventHandler(this.btnSalir_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosVentaCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCobrosVentaCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLineaCreditoVentaID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox txtMontoPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}