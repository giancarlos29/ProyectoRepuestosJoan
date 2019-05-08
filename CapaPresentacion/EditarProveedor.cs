using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class EditarProveedor : Form
    {
        private static EditarProveedor frmInstance = null;
        ProveedoresNegocio proveedoresNegocio = new ProveedoresNegocio();
        Proveedore proveedorEntidad = new Proveedore();
        TextBox[] textBoxes;

        public static EditarProveedor Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new EditarProveedor();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public EditarProveedor()
        {
            InitializeComponent();
            textBoxes = new TextBox[] { txtNombre, txtCedulaORnc, txtDireccion, txtContacto1, txtContacto2, txtDatoAdicional };
        }

        private void EditarProveedor_Load(object sender, EventArgs e)
        {
            if (Login.userLevel == 1)
                btnEliminarProveedor.Enabled = true;

            LlenarTextBox();
           

        }

        private void LlenarTextBox()
        {
            var result = proveedoresNegocio.BuscarProveedoresPorID(BuscarProveedores.proveedorID).FirstOrDefault();
            txtProveedorID.Text = BuscarProveedores.proveedorID.ToString();
            txtNombre.Text = result.Nombre;
            txtCedulaORnc.Text = result.CedulaORnc;
            txtDireccion.Text = result.Direccion;
            txtContacto1.Text = result.Contacto_1;
            txtContacto2.Text = result.Contacto_2;
            txtDatoAdicional.Text = result.DatoAdicional.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            proveedorEntidad.ProveedorID = Convert.ToInt32(txtProveedorID.Text);
            proveedorEntidad.Nombre = txtNombre.Text;
            proveedorEntidad.CedulaORnc = txtCedulaORnc.Text;
            proveedorEntidad.Direccion = txtDireccion.Text;
            proveedorEntidad.Contacto_1 = txtContacto1.Text;
            proveedorEntidad.Contacto_2 = txtContacto2.Text;
            proveedorEntidad.DatoAdicional = txtDatoAdicional.Text;

            bool result = proveedoresNegocio.EditarProveedor(proveedorEntidad);
            ValidarEditarProveedor(result);

        }

        public void ValidarEditarProveedor(bool result)
        {
            if (result)
            {
                MessageBox.Show(string.Format("El proveedor ha sido editado correctamente en la base de datos."), "Proveedor Editado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El proveedor no pudo ser editado, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            BuscarProveedores.verificar = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in textBoxes)
            {
                txtBox.Clear();
            }
            txtNombre.Select();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            bool result = proveedoresNegocio.BorrarProveedor(Convert.ToInt32(txtProveedorID.Text));
            ValidarBorrarProveedor(result);
        }

            public void ValidarBorrarProveedor(bool result)
            {
                if (result)
                {
                    MessageBox.Show(string.Format("El proveedor ha sido borrado correctamente en la base de datos."), "Proveedor Borrado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El proveedor no pudo ser borrado, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
    }
}
