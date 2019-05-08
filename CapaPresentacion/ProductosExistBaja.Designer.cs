namespace CapaPresentacion
{
    partial class ProductosExistBaja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnReferencia = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.rbtnDescripcion = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvProdExistBaja = new System.Windows.Forms.DataGridView();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdExistBaja)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnReferencia);
            this.groupBox1.Controls.Add(this.rbtnCodigo);
            this.groupBox1.Controls.Add(this.rbtnDescripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(222, 65);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
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
            this.rbtnCodigo.Location = new System.Drawing.Point(11, 42);
            this.rbtnCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtnCodigo.TabIndex = 12;
            this.rbtnCodigo.Text = "Codigo";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // rbtnDescripcion
            // 
            this.rbtnDescripcion.AutoSize = true;
            this.rbtnDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDescripcion.Location = new System.Drawing.Point(140, 44);
            this.rbtnDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDescripcion.Name = "rbtnDescripcion";
            this.rbtnDescripcion.Size = new System.Drawing.Size(81, 17);
            this.rbtnDescripcion.TabIndex = 10;
            this.rbtnDescripcion.Text = "Descripcion";
            this.rbtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 92);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(222, 65);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvProdExistBaja
            // 
            this.dgvProdExistBaja.AllowUserToAddRows = false;
            this.dgvProdExistBaja.AllowUserToDeleteRows = false;
            this.dgvProdExistBaja.AllowUserToOrderColumns = true;
            this.dgvProdExistBaja.AllowUserToResizeRows = false;
            this.dgvProdExistBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdExistBaja.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProdExistBaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdExistBaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdExistBaja.ColumnHeadersHeight = 32;
            this.dgvProdExistBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoID,
            this.Referencia,
            this.Descripcion,
            this.ProveedorID,
            this.Existencia,
            this.CantMin,
            this.CantMax});
            this.dgvProdExistBaja.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdExistBaja.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdExistBaja.EnableHeadersVisualStyles = false;
            this.dgvProdExistBaja.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProdExistBaja.Location = new System.Drawing.Point(1, 171);
            this.dgvProdExistBaja.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdExistBaja.Name = "dgvProdExistBaja";
            this.dgvProdExistBaja.ReadOnly = true;
            this.dgvProdExistBaja.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdExistBaja.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdExistBaja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProdExistBaja.Size = new System.Drawing.Size(916, 180);
            this.dgvProdExistBaja.TabIndex = 44;
            this.dgvProdExistBaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdExistBaja_CellClick);
            // 
            // ProductoID
            // 
            this.ProductoID.DataPropertyName = "ProductoID";
            this.ProductoID.DividerWidth = 2;
            this.ProductoID.FillWeight = 113.7056F;
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.DividerWidth = 2;
            this.Referencia.FillWeight = 113.7056F;
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 113.7056F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ProveedorID
            // 
            this.ProveedorID.DataPropertyName = "ProveedorID";
            this.ProveedorID.HeaderText = "ProveedorID";
            this.ProveedorID.Name = "ProveedorID";
            this.ProveedorID.ReadOnly = true;
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "Existencia";
            this.Existencia.DividerWidth = 2;
            this.Existencia.FillWeight = 113.7056F;
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // CantMin
            // 
            this.CantMin.DataPropertyName = "CantMin";
            this.CantMin.DividerWidth = 2;
            this.CantMin.FillWeight = 113.7056F;
            this.CantMin.HeaderText = "Cant. Min";
            this.CantMin.Name = "CantMin";
            this.CantMin.ReadOnly = true;
            // 
            // CantMax
            // 
            this.CantMax.DataPropertyName = "CantMax";
            this.CantMax.FillWeight = 113.7056F;
            this.CantMax.HeaderText = "CantMax";
            this.CantMax.Name = "CantMax";
            this.CantMax.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(711, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(195, 146);
            this.groupBox2.TabIndex = 40;
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
            this.btnSalir.Location = new System.Drawing.Point(48, 58);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 46);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ProductosExistBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(918, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProdExistBaja);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "ProductosExistBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosExistBaja";
            this.Load += new System.EventHandler(this.ProductosExistBaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdExistBaja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnReferencia;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.RadioButton rbtnDescripcion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvProdExistBaja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMax;
        private System.Windows.Forms.Button btnSalir;
    }
}