using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InventariarProducto : Form
    {
        private static InventariarProducto frmInstance = null;
        public static double cantInventariada;

        public static InventariarProducto Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new InventariarProducto();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public InventariarProducto()
        {
            InitializeComponent();
        }

        private void InventariarProducto_Load(object sender, EventArgs e)
        {
            CargarTxtCantidad();
            txtCantidad.Focus();
        }

        private void CargarTxtCantidad()
        {
            txtCantidad.Text = ProductosADevolver.cantRecibida.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
                ModificarCantInventariada();
            else
                MessageBox.Show("Cantidad no puede estar vacia...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ModificarCantInventariada()
        {
            cantInventariada = Convert.ToDouble(txtCantidad.Text);
            if (VerificarCantInventariada())
            {
                ProductosADevolver.verificarInventariarProducto = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cantidad inventariada sobrepasa a la cantidad recibida del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Clear();
            }          
            
        }

        private bool VerificarCantInventariada()
        {
            if (ProductosADevolver.cantRecibida < cantInventariada)
                return false;
            else
                return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
