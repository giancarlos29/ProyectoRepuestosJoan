namespace CapaPresentacion
{
    partial class ProductosPorProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosPorProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDescripcion = new System.Windows.Forms.RadioButton();
            this.rbtnReferencia = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDesmarcarTodo = new System.Windows.Forms.Button();
            this.btnMarcarTodo = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cbSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProdExistBaja = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.txtNomProveedor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDescripcion);
            this.groupBox1.Controls.Add(this.rbtnReferencia);
            this.groupBox1.Controls.Add(this.rbtnCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(270, 65);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // rbtnDescripcion
            // 
            this.rbtnDescripcion.AutoSize = true;
            this.rbtnDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDescripcion.Location = new System.Drawing.Point(150, 21);
            this.rbtnDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDescripcion.Name = "rbtnDescripcion";
            this.rbtnDescripcion.Size = new System.Drawing.Size(81, 17);
            this.rbtnDescripcion.TabIndex = 13;
            this.rbtnDescripcion.Text = "Descripcion";
            this.rbtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbtnReferencia
            // 
            this.rbtnReferencia.AutoSize = true;
            this.rbtnReferencia.Checked = true;
            this.rbtnReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnReferencia.Location = new System.Drawing.Point(69, 21);
            this.rbtnReferencia.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnReferencia.Name = "rbtnReferencia";
            this.rbtnReferencia.Size = new System.Drawing.Size(77, 17);
            this.rbtnReferencia.TabIndex = 11;
            this.rbtnReferencia.TabStop = true;
            this.rbtnReferencia.Text = "Referencia";
            this.rbtnReferencia.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCodigo.Location = new System.Drawing.Point(97, 42);
            this.rbtnCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(119, 17);
            this.rbtnCodigo.TabIndex = 12;
            this.rbtnCodigo.Text = "Codigo de Producto";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnDesmarcarTodo);
            this.groupBox2.Controls.Add(this.btnMarcarTodo);
            this.groupBox2.Controls.Add(this.btnSeleccionar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(685, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(464, 142);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar Accion:";
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
            this.btnSalir.Location = new System.Drawing.Point(356, 45);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 51);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDesmarcarTodo
            // 
            this.btnDesmarcarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnDesmarcarTodo.Image")));
            this.btnDesmarcarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesmarcarTodo.Location = new System.Drawing.Point(30, 80);
            this.btnDesmarcarTodo.Name = "btnDesmarcarTodo";
            this.btnDesmarcarTodo.Size = new System.Drawing.Size(131, 49);
            this.btnDesmarcarTodo.TabIndex = 37;
            this.btnDesmarcarTodo.Text = "Desmarcar Todo";
            this.btnDesmarcarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesmarcarTodo.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodo.Click += new System.EventHandler(this.btnDesmarcarTodo_Click);
            // 
            // btnMarcarTodo
            // 
            this.btnMarcarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcarTodo.Image")));
            this.btnMarcarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarTodo.Location = new System.Drawing.Point(30, 20);
            this.btnMarcarTodo.Name = "btnMarcarTodo";
            this.btnMarcarTodo.Size = new System.Drawing.Size(131, 50);
            this.btnMarcarTodo.TabIndex = 38;
            this.btnMarcarTodo.Text = "Marcar Todo";
            this.btnMarcarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarcarTodo.UseVisualStyleBackColor = true;
            this.btnMarcarTodo.Click += new System.EventHandler(this.btnMarcarTodo_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AccessibleDescription = "";
            this.btnSeleccionar.AccessibleName = "";
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::CapaPresentacion.Properties.Resources.packageadd;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(182, 45);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(159, 49);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 83);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(270, 65);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(242, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.ColumnHeadersHeight = 30;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbSeleccionar,
            this.ProductoID,
            this.Referencia,
            this.Descripcion,
            this.Calidad,
            this.Existencia,
            this.CantMin,
            this.CantMax,
            this.PrecioCompra});
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.Location = new System.Drawing.Point(1, 157);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.Size = new System.Drawing.Size(1159, 180);
            this.dgvProductos.TabIndex = 32;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // cbSeleccionar
            // 
            this.cbSeleccionar.FalseValue = "false";
            this.cbSeleccionar.FillWeight = 20.30457F;
            this.cbSeleccionar.HeaderText = "";
            this.cbSeleccionar.Name = "cbSeleccionar";
            this.cbSeleccionar.ReadOnly = true;
            this.cbSeleccionar.TrueValue = "true";
            // 
            // ProductoID
            // 
            this.ProductoID.DataPropertyName = "ProductoID";
            this.ProductoID.HeaderText = "ID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            this.ProductoID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Calidad
            // 
            this.Calidad.DataPropertyName = "Calidad";
            this.Calidad.HeaderText = "Calidad";
            this.Calidad.Name = "Calidad";
            this.Calidad.ReadOnly = true;
            this.Calidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "Existencia";
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            this.Existencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CantMin
            // 
            this.CantMin.DataPropertyName = "CantMin";
            this.CantMin.HeaderText = "Cant Min";
            this.CantMin.Name = "CantMin";
            this.CantMin.ReadOnly = true;
            this.CantMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CantMax
            // 
            this.CantMax.DataPropertyName = "CantMax";
            this.CantMax.HeaderText = "Cant Max";
            this.CantMax.Name = "CantMax";
            this.CantMax.ReadOnly = true;
            this.CantMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.DataPropertyName = "PrecioCompra";
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cbProdExistBaja
            // 
            this.cbProdExistBaja.AutoSize = true;
            this.cbProdExistBaja.Checked = true;
            this.cbProdExistBaja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProdExistBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdExistBaja.Location = new System.Drawing.Point(295, 130);
            this.cbProdExistBaja.Name = "cbProdExistBaja";
            this.cbProdExistBaja.Size = new System.Drawing.Size(262, 20);
            this.cbProdExistBaja.TabIndex = 35;
            this.cbProdExistBaja.Text = "Mostrar Solo Productos Existencia Baja";
            this.cbProdExistBaja.UseVisualStyleBackColor = true;
            this.cbProdExistBaja.CheckedChanged += new System.EventHandler(this.cbProdExistBaja_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtCodProveedor);
            this.groupBox4.Controls.Add(this.txtNomProveedor);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(294, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(222, 113);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Codigo:";
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodProveedor.Location = new System.Drawing.Point(78, 30);
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.ReadOnly = true;
            this.txtCodProveedor.Size = new System.Drawing.Size(36, 26);
            this.txtCodProveedor.TabIndex = 40;
            // 
            // txtNomProveedor
            // 
            this.txtNomProveedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomProveedor.Location = new System.Drawing.Point(92, 78);
            this.txtNomProveedor.Name = "txtNomProveedor";
            this.txtNomProveedor.ReadOnly = true;
            this.txtNomProveedor.Size = new System.Drawing.Size(125, 26);
            this.txtNomProveedor.TabIndex = 41;
            // 
            // ProductosPorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1160, 338);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbProdExistBaja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProductos);
            this.MaximizeBox = false;
            this.Name = "ProductosPorProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosPorProveedor";
            this.Load += new System.EventHandler(this.ProductosPorProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDescripcion;
        private System.Windows.Forms.RadioButton rbtnReferencia;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.CheckBox cbProdExistBaja;
        private System.Windows.Forms.Button btnDesmarcarTodo;
        private System.Windows.Forms.Button btnMarcarTodo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.TextBox txtNomProveedor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
    }
}