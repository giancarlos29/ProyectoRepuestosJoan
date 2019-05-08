namespace CapaPresentacion
{
    partial class LineasCreditoVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.rbtnFactura = new System.Windows.Forms.RadioButton();
            this.rbtnLineaCreditoVenta = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvLineasVentasCredito = new System.Windows.Forms.DataGridView();
            this.OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompletado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnHistorialCobros = new System.Windows.Forms.Button();
            this.btnRealizarCobro = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnLineasVencidas = new System.Windows.Forms.RadioButton();
            this.rbtnLineasPendiente = new System.Windows.Forms.RadioButton();
            this.rbtnLineasCompletas = new System.Windows.Forms.RadioButton();
            this.rbtnTodasLineas = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineasVentasCredito)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCliente);
            this.groupBox1.Controls.Add(this.rbtnFactura);
            this.groupBox1.Controls.Add(this.rbtnLineaCreditoVenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(222, 65);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Checked = true;
            this.rbtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCliente.Location = new System.Drawing.Point(98, 14);
            this.rbtnCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Size = new System.Drawing.Size(57, 17);
            this.rbtnCliente.TabIndex = 11;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "Cliente";
            this.rbtnCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnFactura
            // 
            this.rbtnFactura.AutoSize = true;
            this.rbtnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFactura.Location = new System.Drawing.Point(11, 38);
            this.rbtnFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnFactura.Name = "rbtnFactura";
            this.rbtnFactura.Size = new System.Drawing.Size(61, 17);
            this.rbtnFactura.TabIndex = 12;
            this.rbtnFactura.Text = "Factura";
            this.rbtnFactura.UseVisualStyleBackColor = true;
            // 
            // rbtnLineaCreditoVenta
            // 
            this.rbtnLineaCreditoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLineaCreditoVenta.Location = new System.Drawing.Point(87, 31);
            this.rbtnLineaCreditoVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnLineaCreditoVenta.Name = "rbtnLineaCreditoVenta";
            this.rbtnLineaCreditoVenta.Size = new System.Drawing.Size(124, 30);
            this.rbtnLineaCreditoVenta.TabIndex = 10;
            this.rbtnLineaCreditoVenta.Text = "Linea Credito Venta";
            this.rbtnLineaCreditoVenta.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 88);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(222, 65);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 26);
            this.txtBuscar.TabIndex = 0;
            // 
            // dgvLineasVentasCredito
            // 
            this.dgvLineasVentasCredito.AllowUserToAddRows = false;
            this.dgvLineasVentasCredito.AllowUserToDeleteRows = false;
            this.dgvLineasVentasCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLineasVentasCredito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLineasVentasCredito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLineasVentasCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLineasVentasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineasVentasCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenCompra,
            this.FacturaID,
            this.ClienteID1,
            this.FechaPedido,
            this.FechaCompletado,
            this.Estatus,
            this.Estatus1});
            this.dgvLineasVentasCredito.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLineasVentasCredito.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLineasVentasCredito.EnableHeadersVisualStyles = false;
            this.dgvLineasVentasCredito.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLineasVentasCredito.Location = new System.Drawing.Point(0, 168);
            this.dgvLineasVentasCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLineasVentasCredito.Name = "dgvLineasVentasCredito";
            this.dgvLineasVentasCredito.ReadOnly = true;
            this.dgvLineasVentasCredito.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLineasVentasCredito.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLineasVentasCredito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLineasVentasCredito.Size = new System.Drawing.Size(916, 180);
            this.dgvLineasVentasCredito.TabIndex = 37;
            this.dgvLineasVentasCredito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLineasVentasCredito_CellClick);
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.DataPropertyName = "LineaCreditoVentaID";
            this.OrdenCompra.HeaderText = "ID";
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.ReadOnly = true;
            // 
            // FacturaID
            // 
            this.FacturaID.DataPropertyName = "FacturaID";
            this.FacturaID.HeaderText = "Numero Factura";
            this.FacturaID.Name = "FacturaID";
            this.FacturaID.ReadOnly = true;
            // 
            // ClienteID1
            // 
            this.ClienteID1.DataPropertyName = "ClienteID";
            this.ClienteID1.HeaderText = "ClienteID";
            this.ClienteID1.Name = "ClienteID1";
            this.ClienteID1.ReadOnly = true;
            // 
            // FechaPedido
            // 
            this.FechaPedido.DataPropertyName = "Fecha";
            this.FechaPedido.HeaderText = "Fecha Factura";
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.ReadOnly = true;
            // 
            // FechaCompletado
            // 
            this.FechaCompletado.DataPropertyName = "MontoFactura";
            this.FechaCompletado.HeaderText = "Monto Factura";
            this.FechaCompletado.Name = "FechaCompletado";
            this.FechaCompletado.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "MontoPendiente";
            this.Estatus.HeaderText = "Balance Pendiente";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // Estatus1
            // 
            this.Estatus1.DataPropertyName = "Estatus";
            this.Estatus1.HeaderText = "Estatus";
            this.Estatus1.Name = "Estatus1";
            this.Estatus1.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFacturar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnHistorialCobros);
            this.groupBox2.Controls.Add(this.btnRealizarCobro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(458, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(447, 156);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar Accion:";
            // 
            // btnFacturar
            // 
            this.btnFacturar.AccessibleDescription = "";
            this.btnFacturar.AccessibleName = "";
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFacturar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Image = global::CapaPresentacion.Properties.Resources.retouren;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(27, 94);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(147, 58);
            this.btnFacturar.TabIndex = 18;
            this.btnFacturar.Text = "Consultar Factura";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.UseVisualStyleBackColor = true;
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
            this.btnSalir.Location = new System.Drawing.Point(340, 57);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 51);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHistorialCobros
            // 
            this.btnHistorialCobros.AccessibleDescription = "";
            this.btnHistorialCobros.AccessibleName = "";
            this.btnHistorialCobros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorialCobros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialCobros.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCobros.Image = global::CapaPresentacion.Properties.Resources.ordenlist1;
            this.btnHistorialCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialCobros.Location = new System.Drawing.Point(27, 31);
            this.btnHistorialCobros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistorialCobros.Name = "btnHistorialCobros";
            this.btnHistorialCobros.Size = new System.Drawing.Size(147, 59);
            this.btnHistorialCobros.TabIndex = 13;
            this.btnHistorialCobros.Text = "Historial Cobros";
            this.btnHistorialCobros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorialCobros.UseVisualStyleBackColor = true;
            this.btnHistorialCobros.Click += new System.EventHandler(this.btnHistorialCobros_Click);
            // 
            // btnRealizarCobro
            // 
            this.btnRealizarCobro.AccessibleDescription = "";
            this.btnRealizarCobro.AccessibleName = "";
            this.btnRealizarCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRealizarCobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarCobro.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarCobro.Image = global::CapaPresentacion.Properties.Resources.cambiarcosto;
            this.btnRealizarCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarCobro.Location = new System.Drawing.Point(187, 53);
            this.btnRealizarCobro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRealizarCobro.Name = "btnRealizarCobro";
            this.btnRealizarCobro.Size = new System.Drawing.Size(140, 59);
            this.btnRealizarCobro.TabIndex = 15;
            this.btnRealizarCobro.Text = "Realizar Cobro";
            this.btnRealizarCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRealizarCobro.UseVisualStyleBackColor = true;
            this.btnRealizarCobro.Click += new System.EventHandler(this.btnRealizarCobro_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnLineasVencidas);
            this.groupBox4.Controls.Add(this.rbtnLineasPendiente);
            this.groupBox4.Controls.Add(this.rbtnLineasCompletas);
            this.groupBox4.Controls.Add(this.rbtnTodasLineas);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(243, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(203, 131);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrar Por:";
            // 
            // rbtnLineasVencidas
            // 
            this.rbtnLineasVencidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLineasVencidas.Location = new System.Drawing.Point(11, 69);
            this.rbtnLineasVencidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnLineasVencidas.Name = "rbtnLineasVencidas";
            this.rbtnLineasVencidas.Size = new System.Drawing.Size(114, 30);
            this.rbtnLineasVencidas.TabIndex = 13;
            this.rbtnLineasVencidas.Text = "Lineas Vencidas";
            this.rbtnLineasVencidas.UseVisualStyleBackColor = true;
            // 
            // rbtnLineasPendiente
            // 
            this.rbtnLineasPendiente.AutoSize = true;
            this.rbtnLineasPendiente.Checked = true;
            this.rbtnLineasPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLineasPendiente.Location = new System.Drawing.Point(11, 22);
            this.rbtnLineasPendiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnLineasPendiente.Name = "rbtnLineasPendiente";
            this.rbtnLineasPendiente.Size = new System.Drawing.Size(107, 17);
            this.rbtnLineasPendiente.TabIndex = 11;
            this.rbtnLineasPendiente.TabStop = true;
            this.rbtnLineasPendiente.Text = "Lineas Pendiente";
            this.rbtnLineasPendiente.UseVisualStyleBackColor = true;
            this.rbtnLineasPendiente.CheckedChanged += new System.EventHandler(this.rbtnLineasPendiente_CheckedChanged);
            // 
            // rbtnLineasCompletas
            // 
            this.rbtnLineasCompletas.AutoSize = true;
            this.rbtnLineasCompletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLineasCompletas.Location = new System.Drawing.Point(11, 49);
            this.rbtnLineasCompletas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnLineasCompletas.Name = "rbtnLineasCompletas";
            this.rbtnLineasCompletas.Size = new System.Drawing.Size(115, 17);
            this.rbtnLineasCompletas.TabIndex = 12;
            this.rbtnLineasCompletas.Text = "Lineas Completada";
            this.rbtnLineasCompletas.UseVisualStyleBackColor = true;
            // 
            // rbtnTodasLineas
            // 
            this.rbtnTodasLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTodasLineas.Location = new System.Drawing.Point(11, 93);
            this.rbtnTodasLineas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnTodasLineas.Name = "rbtnTodasLineas";
            this.rbtnTodasLineas.Size = new System.Drawing.Size(114, 30);
            this.rbtnTodasLineas.TabIndex = 10;
            this.rbtnTodasLineas.Text = "Todas las Lineas";
            this.rbtnTodasLineas.UseVisualStyleBackColor = true;
            // 
            // LineasCreditoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(913, 348);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvLineasVentasCredito);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LineasCreditoVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas a Credito";
            this.Load += new System.EventHandler(this.LineasCreditoVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineasVentasCredito)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.RadioButton rbtnFactura;
        private System.Windows.Forms.RadioButton rbtnLineaCreditoVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvLineasVentasCredito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnHistorialCobros;
        private System.Windows.Forms.Button btnRealizarCobro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnLineasPendiente;
        private System.Windows.Forms.RadioButton rbtnLineasCompletas;
        private System.Windows.Forms.RadioButton rbtnTodasLineas;
        private System.Windows.Forms.RadioButton rbtnLineasVencidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompletado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus1;
    }
}