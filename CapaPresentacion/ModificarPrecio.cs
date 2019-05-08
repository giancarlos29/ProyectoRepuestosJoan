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
    public partial class ModificarPrecio : Form
    {
        public static decimal precio;
        private static ModificarPrecio frmInstance = null;

        public static ModificarPrecio Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ModificarPrecio();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public ModificarPrecio()
        {
            InitializeComponent();
        }

        private void ModificarPrecio_Load(object sender, EventArgs e)
        {
            CargarTxtPrecio();
            txtPrecio.Focus();
        }

        private void CargarTxtPrecio()
        {
            txtPrecio.Text = Convert.ToString(DetallesOrdenCompra.precio);
        }

       

    private void CargarVariableprecio()
    {
        precio = Convert.ToDecimal(txtPrecio.Text);
        DetallesOrdenCompra.verificarModPrecio = true;
    }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarVariableprecio();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
