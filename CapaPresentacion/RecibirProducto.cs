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
    public partial class RecibirProducto : Form
    {
        private static RecibirProducto frmInstance = null;
        public static double cantRecibida;
        public static string comentario;

        public static RecibirProducto Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new RecibirProducto();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public RecibirProducto()
        {
            InitializeComponent();
        }

        private void RecibirProducto_Load(object sender, EventArgs e)
        {
            CargarTxtCantidad();            
            txtCantidad.Focus();
        }


        private void CargarTxtCantidad()
        {
            txtCantidad.Text = ProductosADevolver.cantVen.ToString();
            txtComentario.Clear();
        }
        private void ModificarCantRecibida()
        {
            cantRecibida = Convert.ToDouble(txtCantidad.Text);
            comentario = Convert.ToString(txtComentario.Text);
            if (VerificarCantRecibida())
            {
                ProductosADevolver.verificarRecibirProducto = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cantidad recibida sobrepasa a la cantidad vendida del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Clear();
            }


        }


        private bool VerificarCantRecibida()
        {
            if (ProductosADevolver.cantVen < cantRecibida)
                return false;
            else
                return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtComentario.Text))
                ModificarCantRecibida();
            else
                MessageBox.Show("Campo Cantidad o Comentario no pueden estar vacio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
