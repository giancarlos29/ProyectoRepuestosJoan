namespace CapaPresentacion
{
    partial class BuscarProveedores
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCedulaORnc = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.ProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaORNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatoAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnCompra);
            this.groupBox2.Controls.Add(this.btnEditarProveedor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(513, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 225);
            this.groupBox2.TabIndex = 25;
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
            this.btnSalir.Location = new System.Drawing.Point(676, 68);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 78);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.AccessibleDescription = "";
            this.btnCompra.AccessibleName = "";
            this.btnCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Image = global::CapaPresentacion.Properties.Resources.compraproveedor1;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(42, 68);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(160, 75);
            this.btnCompra.TabIndex = 13;
            this.btnCompra.Text = "Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tTip.SetToolTip(this.btnCompra, "Haga clic aqui para realizar una orden de compra");
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.AccessibleDescription = "";
            this.btnEditarProveedor.AccessibleName = "";
            this.btnEditarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProveedor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.Image = global::CapaPresentacion.Properties.Resources.editarProveedor1;
            this.btnEditarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProveedor.Location = new System.Drawing.Point(249, 68);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(154, 75);
            this.btnEditarProveedor.TabIndex = 15;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProveedor.UseVisualStyleBackColor = true;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCedulaORnc);
            this.groupBox1.Controls.Add(this.rbtnCodigo);
            this.groupBox1.Controls.Add(this.rbtnNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // rbtnCedulaORnc
            // 
            this.rbtnCedulaORnc.AutoSize = true;
            this.rbtnCedulaORnc.Checked = true;
            this.rbtnCedulaORnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCedulaORnc.Location = new System.Drawing.Point(104, 32);
            this.rbtnCedulaORnc.Name = "rbtnCedulaORnc";
            this.rbtnCedulaORnc.Size = new System.Drawing.Size(122, 24);
            this.rbtnCedulaORnc.TabIndex = 11;
            this.rbtnCedulaORnc.TabStop = true;
            this.rbtnCedulaORnc.Text = "Cedula/RNC";
            this.rbtnCedulaORnc.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCodigo.Location = new System.Drawing.Point(16, 65);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(84, 24);
            this.rbtnCodigo.TabIndex = 12;
            this.rbtnCodigo.Text = "Codigo";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNombre.Location = new System.Drawing.Point(225, 68);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(90, 24);
            this.rbtnNombre.TabIndex = 10;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 100);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(16, 43);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 35);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedor.ColumnHeadersHeight = 32;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProveedorID,
            this.Nombre,
            this.CedulaORNC,
            this.Direccion,
            this.Contacto_1,
            this.Contacto_2,
            this.DatoAdicional});
            this.dgvProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedor.EnableHeadersVisualStyles = false;
            this.dgvProveedor.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProveedor.Location = new System.Drawing.Point(0, 263);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProveedor.Size = new System.Drawing.Size(1374, 277);
            this.dgvProveedor.TabIndex = 28;
            this.dgvProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellClick);
            // 
            // ProveedorID
            // 
            this.ProveedorID.DataPropertyName = "ProveedorID";
            this.ProveedorID.DividerWidth = 2;
            this.ProveedorID.HeaderText = "ProveedorID";
            this.ProveedorID.Name = "ProveedorID";
            this.ProveedorID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.DividerWidth = 2;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CedulaORNC
            // 
            this.CedulaORNC.DataPropertyName = "CedulaORNC";
            this.CedulaORNC.HeaderText = "Cedula/RNC";
            this.CedulaORNC.Name = "CedulaORNC";
            this.CedulaORNC.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.DividerWidth = 2;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Contacto_1
            // 
            this.Contacto_1.DataPropertyName = "Contacto_1";
            this.Contacto_1.DividerWidth = 2;
            this.Contacto_1.HeaderText = "Contacto 1";
            this.Contacto_1.Name = "Contacto_1";
            this.Contacto_1.ReadOnly = true;
            // 
            // Contacto_2
            // 
            this.Contacto_2.DataPropertyName = "Contacto_2";
            this.Contacto_2.DividerWidth = 2;
            this.Contacto_2.HeaderText = "Contacto 2";
            this.Contacto_2.Name = "Contacto_2";
            this.Contacto_2.ReadOnly = true;
            // 
            // DatoAdicional
            // 
            this.DatoAdicional.DataPropertyName = "DatoAdicional";
            this.DatoAdicional.DividerWidth = 2;
            this.DatoAdicional.HeaderText = "DatoAdicional";
            this.DatoAdicional.Name = "DatoAdicional";
            this.DatoAdicional.ReadOnly = true;
            // 
            // tTip
            // 
            this.tTip.AutomaticDelay = 0;
            this.tTip.AutoPopDelay = 5500;
            this.tTip.InitialDelay = 1;
            this.tTip.ReshowDelay = 110;
            this.tTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tTip.ToolTipTitle = "Informacion";
            // 
            // BuscarProveedores
            // 
            this.AcceptButton = this.btnCompra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1370, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "BuscarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Proveedores";
            this.Activated += new System.EventHandler(this.BuscarProveedores_Activated);
            this.Load += new System.EventHandler(this.BuscarProovedores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCedulaORnc;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaORNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatoAdicional;
        private System.Windows.Forms.ToolTip tTip;
    }
}