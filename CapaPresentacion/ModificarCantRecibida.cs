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
    public partial class ModificarCantRecibida : Form
    {
        private static ModificarCantRecibida frmInstance = null;
        public static double cantRecibida;

        public static ModificarCantRecibida Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ModificarCantRecibida();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public ModificarCantRecibida()
        {
            InitializeComponent();
        }

        private void ModificarCantRecibida_Load(object sender, EventArgs e)
        {
            CargarTextBox();
            txtCantRecibida.Focus();
        }
        private void CargarTextBox()
        {
            txtCantRecibida.Text = Convert.ToString(DetallesOrdenCompra.cantRecibida);
        }

        private void CargarVariableCantRecibida()
        {
            cantRecibida = Convert.ToDouble(txtCantRecibida.Text);
            DetallesOrdenCompra.verificarModCantRecibida = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarVariableCantRecibida();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
