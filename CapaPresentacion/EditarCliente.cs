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
    public partial class EditarCliente : Form
    {
        private static EditarCliente frmInstance = null;
        ClientesNegocio clientesNegocio = new ClientesNegocio();
        Cliente clienteEntidad = new Cliente();
        TextBox[] textBoxes;


        public static EditarCliente Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new EditarCliente();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public EditarCliente()
        {
            InitializeComponent();
            textBoxes = new TextBox[] { txtNombre, txtCedulaORnc, txtDireccion, txtContacto1, txtContacto2, txtDescuento };
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            if (Login.userLevel == 1)
                btnEliminarCliente.Enabled = true;

            var result = clientesNegocio.BuscarClientesPorID(BuscarClientes.clienteID).FirstOrDefault();
            txtClienteID.Text = BuscarClientes.clienteID.ToString();
            txtNombre.Text = result.Nombre;
            txtCedulaORnc.Text = result.CedulaORnc;
            txtDireccion.Text = result.Direccion;
            txtContacto1.Text = result.Contacto_1;
            txtContacto2.Text = result.Contacto_2;
            txtDescuento.Text = result.Descuento.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            clienteEntidad.ClienteID = Convert.ToInt32(txtClienteID.Text);
            clienteEntidad.Nombre = txtNombre.Text;
            clienteEntidad.CedulaORnc = txtCedulaORnc.Text;
            clienteEntidad.Direccion = txtDireccion.Text;
            clienteEntidad.Contacto_1 = txtContacto1.Text;
            clienteEntidad.Contacto_2 = txtContacto2.Text;
            if (!string.IsNullOrEmpty(txtDescuento.Text))
                clienteEntidad.Descuento = Convert.ToDouble(txtDescuento.Text);
            else
            {
                clienteEntidad.Descuento = 0;
            }

            bool result = clientesNegocio.EditarCliente(clienteEntidad);
            ValidarEditarCliente(result);
            
        }

        public void ValidarEditarCliente(bool result)
        {
            if (result)
            {           
                    MessageBox.Show(string.Format("El cliente ha sido editado correctamente en la base de datos."), "Cliente Editado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    MessageBox.Show("El cliente no pudo ser editado, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void EditarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            BuscarClientes.verificar = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in textBoxes)
            {
                txtBox.Clear();
            }
            txtNombre.Select();
        }
        

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            bool result = clientesNegocio.BorrarCliente(Convert.ToInt32(txtClienteID.Text));
            ValidarBorrarCliente(result);
        }

        public void ValidarBorrarCliente(bool result)
        {
            if (result)
            {
                MessageBox.Show(string.Format("El cliente ha sido borrado correctamente en la base de datos."), "Cliente Borrado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El cliente no pudo ser borrado, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

