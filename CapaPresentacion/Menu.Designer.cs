namespace CapaPresentacion
{
    partial class MenuPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnBuscarClientes = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnBuscarProveedores = new System.Windows.Forms.PictureBox();
            this.btnBuscarProductos = new System.Windows.Forms.PictureBox();
            this.btnRealizarCompra = new System.Windows.Forms.PictureBox();
            this.btnRealizarVenta = new System.Windows.Forms.PictureBox();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRealizarCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRealizarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(99, 463);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarClientes.Image = global::CapaPresentacion.Properties.Resources.search_find_client_user_16693;
            this.btnBuscarClientes.Location = new System.Drawing.Point(0, 24);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(91, 74);
            this.btnBuscarClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarClientes.TabIndex = 51;
            this.btnBuscarClientes.TabStop = false;
            this.tTip.SetToolTip(this.btnBuscarClientes, "Haga clic aqui si desea buscar un cliente");
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.logouticon;
            this.btnSalir.Location = new System.Drawing.Point(0, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 74);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 66;
            this.btnSalir.TabStop = false;
            this.tTip.SetToolTip(this.btnSalir, "Salir del sistema");
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarProveedores
            // 
            this.btnBuscarProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedores.Image = global::CapaPresentacion.Properties.Resources.buscarsupplier;
            this.btnBuscarProveedores.Location = new System.Drawing.Point(0, 266);
            this.btnBuscarProveedores.Name = "btnBuscarProveedores";
            this.btnBuscarProveedores.Size = new System.Drawing.Size(91, 74);
            this.btnBuscarProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarProveedores.TabIndex = 68;
            this.btnBuscarProveedores.TabStop = false;
            this.tTip.SetToolTip(this.btnBuscarProveedores, "Presione para buscar un proveedor");
            this.btnBuscarProveedores.Click += new System.EventHandler(this.btnBuscarProveedores_Click);
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProductos.Image = global::CapaPresentacion.Properties.Resources.buscarproduct;
            this.btnBuscarProductos.Location = new System.Drawing.Point(0, 185);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(91, 74);
            this.btnBuscarProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarProductos.TabIndex = 70;
            this.btnBuscarProductos.TabStop = false;
            this.tTip.SetToolTip(this.btnBuscarProductos, "Presione para buscar un producto");
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarCompra.Image = global::CapaPresentacion.Properties.Resources.compraproveedor;
            this.btnRealizarCompra.Location = new System.Drawing.Point(0, 346);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(91, 74);
            this.btnRealizarCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRealizarCompra.TabIndex = 72;
            this.btnRealizarCompra.TabStop = false;
            this.tTip.SetToolTip(this.btnRealizarCompra, "Presione para realizar una compra");
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarVenta.Image = global::CapaPresentacion.Properties.Resources.carritodecompralarge;
            this.btnRealizarVenta.Location = new System.Drawing.Point(0, 105);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(91, 74);
            this.btnRealizarVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRealizarVenta.TabIndex = 74;
            this.btnRealizarVenta.TabStop = false;
            this.tTip.SetToolTip(this.btnRealizarVenta, "Presione para realizar una venta");
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(99, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(701, 25);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondomenuprincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.btnRealizarCompra);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.btnBuscarProveedores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarClientes);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRealizarCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRealizarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox btnBuscarClientes;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnBuscarProveedores;
        private System.Windows.Forms.PictureBox btnBuscarProductos;
        private System.Windows.Forms.PictureBox btnRealizarCompra;
        private System.Windows.Forms.PictureBox btnRealizarVenta;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}