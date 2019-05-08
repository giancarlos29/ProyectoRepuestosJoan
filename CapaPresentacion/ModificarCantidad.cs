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
    public partial class ModificarCantidad : Form
    {
        private static ModificarCantidad frmInstance = null;
        public static double cantidad;

        public static ModificarCantidad Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ModificarCantidad();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public ModificarCantidad()
        {
            InitializeComponent();
        }

        private void ModificarCantidad_Load(object sender, EventArgs e)
        {
            CargarTxtCantidad();
            txtCantidad.Focus();
        }

        private void CargarTxtCantidad()
        {
           txtCantidad.Text = Convert.ToString(DetallesOrdenCompra.cantidad);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarVariableCantidad();
            this.Close();
        }

        private void CargarVariableCantidad()
        {
            cantidad = Convert.ToDouble(txtCantidad.Text);
            DetallesOrdenCompra.verificarModCant = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
