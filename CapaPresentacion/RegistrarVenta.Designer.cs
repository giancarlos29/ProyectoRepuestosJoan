namespace CapaPresentacion
{
    partial class RegistrarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkboxColocarAuto = new System.Windows.Forms.CheckBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtCantArticulos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.CodigoProducto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBIS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPrecioSinItbis = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtItbis = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.btnColocar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCodigoCarrito = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoSocio = new System.Windows.Forms.Label();
            this.checkboxClienteAnonimo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescuentoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ePCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePDescuento = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePCodigoBarra = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePCant = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePCant)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.checkboxColocarAuto);
            this.groupBox1.Controls.Add(this.btnFacturar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtCantArticulos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dgvCarrito);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblPrecioSinItbis);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.txtItbis);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblItbis);
            this.groupBox1.Controls.Add(this.btnColocar);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.btnEliminarProd);
            this.groupBox1.Controls.Add(this.txtCodigoBarra);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.lblCodigoCarrito);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 487);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrito";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkboxColocarAuto
            // 
            this.checkboxColocarAuto.AutoSize = true;
            this.checkboxColocarAuto.Checked = true;
            this.checkboxColocarAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxColocarAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxColocarAuto.Location = new System.Drawing.Point(564, 114);
            this.checkboxColocarAuto.Name = "checkboxColocarAuto";
            this.checkboxColocarAuto.Size = new System.Drawing.Size(212, 24);
            this.checkboxColocarAuto.TabIndex = 83;
            this.checkboxColocarAuto.Text = "Colocar Automaticamente";
            this.checkboxColocarAuto.UseVisualStyleBackColor = true;
            this.checkboxColocarAuto.CheckedChanged += new System.EventHandler(this.checkboxColocarAuto_CheckedChanged);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.White;
            this.btnFacturar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFacturar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Image = global::CapaPresentacion.Properties.Resources._40928706_dinero_del_cajero_automático_símbolo_de_emitir_o_recibir_dinero_de_un_cajero_automático_icono_financiera_s;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(15, 416);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(180, 58);
            this.btnFacturar.TabIndex = 82;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(373, 53);
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(46, 26);
            this.txtCantidad.TabIndex = 81;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCantArticulos
            // 
            this.txtCantArticulos.BackColor = System.Drawing.SystemColors.Info;
            this.txtCantArticulos.Location = new System.Drawing.Point(396, 339);
            this.txtCantArticulos.Name = "txtCantArticulos";
            this.txtCantArticulos.ReadOnly = true;
            this.txtCantArticulos.Size = new System.Drawing.Size(80, 32);
            this.txtCantArticulos.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "Cantidad de articulos en el carrito:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.iconlogout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(459, 85);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 53);
            this.btnSalir.TabIndex = 78;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Controls.Add(this.txtRNC);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(713, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 107);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comprobante Fiscal:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(92, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 30);
            this.txtNombre.TabIndex = 7;
            // 
            // txtRNC
            // 
            this.txtRNC.Enabled = false;
            this.txtRNC.Location = new System.Drawing.Point(92, 29);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(223, 30);
            this.txtRNC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Tag = "Nombre:";
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "RNC:";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToResizeColumns = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCarrito.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.ColumnHeadersHeight = 45;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto1,
            this.CodigoBarra1,
            this.Referencia,
            this.Descripcion,
            this.Cantidad,
            this.PrecioVenta,
            this.ITBIS1,
            this.Descuento1,
            this.Importe});
            this.dgvCarrito.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrito.EnableHeadersVisualStyles = false;
            this.dgvCarrito.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCarrito.Location = new System.Drawing.Point(5, 143);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCarrito.Size = new System.Drawing.Size(1068, 177);
            this.dgvCarrito.TabIndex = 72;
            this.dgvCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellClick);
            this.dgvCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellContentClick);
            // 
            // CodigoProducto1
            // 
            this.CodigoProducto1.DataPropertyName = "ProductoID";
            this.CodigoProducto1.HeaderText = "Codigo Producto";
            this.CodigoProducto1.Name = "CodigoProducto1";
            this.CodigoProducto1.ReadOnly = true;
            // 
            // CodigoBarra1
            // 
            this.CodigoBarra1.DataPropertyName = "CodigoBarra";
            this.CodigoBarra1.HeaderText = "Codigo Barra";
            this.CodigoBarra1.Name = "CodigoBarra1";
            this.CodigoBarra1.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.DividerWidth = 2;
            this.Descripcion.HeaderText = "Descipcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.DividerWidth = 2;
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // ITBIS1
            // 
            this.ITBIS1.HeaderText = "ITBIS";
            this.ITBIS1.Name = "ITBIS1";
            this.ITBIS1.ReadOnly = true;
            // 
            // Descuento1
            // 
            this.Descuento1.HeaderText = "Descuento";
            this.Descuento1.Name = "Descuento1";
            this.Descuento1.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "PrecioTotal";
            this.Importe.DividerWidth = 2;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(914, 401);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(150, 26);
            this.txtDescuento.TabIndex = 76;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(814, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Descuento:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Khaki;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(828, 434);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(237, 45);
            this.txtTotal.TabIndex = 36;
            // 
            // lblPrecioSinItbis
            // 
            this.lblPrecioSinItbis.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioSinItbis.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSinItbis.Location = new System.Drawing.Point(430, 12);
            this.lblPrecioSinItbis.Name = "lblPrecioSinItbis";
            this.lblPrecioSinItbis.Size = new System.Drawing.Size(99, 38);
            this.lblPrecioSinItbis.TabIndex = 58;
            this.lblPrecioSinItbis.Text = "Precio por Unidad";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoEllipsis = true;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(727, 443);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 32);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Total:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(434, 53);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(78, 26);
            this.txtPrecioVenta.TabIndex = 57;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoEllipsis = true;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(814, 339);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(99, 19);
            this.lblSubTotal.TabIndex = 53;
            this.lblSubTotal.Text = "Sub-Total:";
            // 
            // txtItbis
            // 
            this.txtItbis.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtItbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItbis.Location = new System.Drawing.Point(914, 369);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.ReadOnly = true;
            this.txtItbis.Size = new System.Drawing.Size(149, 26);
            this.txtItbis.TabIndex = 56;
            this.txtItbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(374, 27);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(45, 19);
            this.lblCantidad.TabIndex = 50;
            this.lblCantidad.Text = "Cant";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(914, 337);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(150, 26);
            this.txtSubTotal.TabIndex = 54;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(218, 27);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 19);
            this.lblDescripcion.TabIndex = 48;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblItbis
            // 
            this.lblItbis.AutoEllipsis = true;
            this.lblItbis.AutoSize = true;
            this.lblItbis.BackColor = System.Drawing.Color.Transparent;
            this.lblItbis.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItbis.Location = new System.Drawing.Point(850, 371);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(63, 19);
            this.lblItbis.TabIndex = 55;
            this.lblItbis.Text = "ITBIS:";
            // 
            // btnColocar
            // 
            this.btnColocar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColocar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnColocar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocar.Image = global::CapaPresentacion.Properties.Resources.carritodecompra;
            this.btnColocar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColocar.Location = new System.Drawing.Point(12, 85);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(98, 53);
            this.btnColocar.TabIndex = 37;
            this.btnColocar.Text = "Colocar";
            this.btnColocar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColocar.UseVisualStyleBackColor = false;
            this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescripcion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(177, 53);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 26);
            this.txtDescripcion.TabIndex = 46;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarProd.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.Image = global::CapaPresentacion.Properties.Resources.deletproduct;
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(116, 85);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(162, 53);
            this.btnEliminarProd.TabIndex = 38;
            this.btnEliminarProd.Text = "Eliminar artículo";
            this.btnEliminarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(12, 53);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(159, 26);
            this.txtCodigoBarra.TabIndex = 45;
            this.txtCodigoBarra.TextChanged += new System.EventHandler(this.txtCodigoBarra_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.cleanicon;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(284, 85);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 53);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar carrito";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiarCarrito_Click);
            // 
            // lblCodigoCarrito
            // 
            this.lblCodigoCarrito.AutoSize = true;
            this.lblCodigoCarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoCarrito.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCarrito.Location = new System.Drawing.Point(29, 27);
            this.lblCodigoCarrito.Name = "lblCodigoCarrito";
            this.lblCodigoCarrito.Size = new System.Drawing.Size(117, 19);
            this.lblCodigoCarrito.TabIndex = 44;
            this.lblCodigoCarrito.Text = "Codigo Barra";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(70, 43);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(185, 22);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.Text = "Cliente Anonimo";
            // 
            // txtClienteID
            // 
            this.txtClienteID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtClienteID.Enabled = false;
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(156, 17);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(99, 22);
            this.txtClienteID.TabIndex = 0;
            this.txtClienteID.Text = "1";
            this.txtClienteID.TextChanged += new System.EventHandler(this.txtClienteID_TextChanged);
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(18, 49);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(52, 16);
            this.lblSocio.TabIndex = 68;
            this.lblSocio.Text = "Cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.iconodebusqueda;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(408, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 48);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigoSocio
            // 
            this.lblCodigoSocio.AutoSize = true;
            this.lblCodigoSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSocio.Location = new System.Drawing.Point(13, 22);
            this.lblCodigoSocio.Name = "lblCodigoSocio";
            this.lblCodigoSocio.Size = new System.Drawing.Size(112, 16);
            this.lblCodigoSocio.TabIndex = 66;
            this.lblCodigoSocio.Text = "Codigo cliente:";
            // 
            // checkboxClienteAnonimo
            // 
            this.checkboxClienteAnonimo.AutoSize = true;
            this.checkboxClienteAnonimo.Checked = true;
            this.checkboxClienteAnonimo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxClienteAnonimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxClienteAnonimo.Location = new System.Drawing.Point(535, 30);
            this.checkboxClienteAnonimo.Name = "checkboxClienteAnonimo";
            this.checkboxClienteAnonimo.Size = new System.Drawing.Size(144, 24);
            this.checkboxClienteAnonimo.TabIndex = 72;
            this.checkboxClienteAnonimo.Text = "Cliente Anonimo";
            this.checkboxClienteAnonimo.UseVisualStyleBackColor = true;
            this.checkboxClienteAnonimo.CheckedChanged += new System.EventHandler(this.checkboxClienteAnonimo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTipoFactura);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbTipoPago);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(709, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 70);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Factura:";
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Location = new System.Drawing.Point(143, 43);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(174, 24);
            this.cbTipoFactura.TabIndex = 2;
            this.cbTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cbTipoFactura_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Pago:";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(143, 17);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(174, 24);
            this.cbTipoPago.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtDescuentoCliente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkboxClienteAnonimo);
            this.groupBox3.Controls.Add(this.lblCodigoSocio);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.lblSocio);
            this.groupBox3.Controls.Add(this.txtClienteID);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 70);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Cliente";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtDescuentoCliente
            // 
            this.txtDescuentoCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescuentoCliente.Enabled = false;
            this.txtDescuentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoCliente.Location = new System.Drawing.Point(357, 25);
            this.txtDescuentoCliente.Name = "txtDescuentoCliente";
            this.txtDescuentoCliente.Size = new System.Drawing.Size(28, 22);
            this.txtDescuentoCliente.TabIndex = 74;
            this.txtDescuentoCliente.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "%Descuento:";
            // 
            // ePCodigo
            // 
            this.ePCodigo.ContainerControl = this;
            // 
            // ePDescuento
            // 
            this.ePDescuento.ContainerControl = this;
            // 
            // ePCodigoBarra
            // 
            this.ePCodigoBarra.ContainerControl = this;
            // 
            // ePCant
            // 
            this.ePCant.ContainerControl = this;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1079, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta";
            this.Activated += new System.EventHandler(this.RegistrarVenta_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarVenta_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarVenta_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePCant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPrecioSinItbis;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtItbis;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label lblCodigoCarrito;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigoSocio;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.CheckBox checkboxClienteAnonimo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantArticulos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.CheckBox checkboxColocarAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBIS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.TextBox txtDescuentoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider ePCodigo;
        private System.Windows.Forms.ErrorProvider ePDescuento;
        private System.Windows.Forms.ErrorProvider ePCodigoBarra;
        private System.Windows.Forms.ErrorProvider ePCant;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnColocar;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnLimpiar;
    }
}