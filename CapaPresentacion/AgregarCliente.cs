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
    public partial class AgregarCliente : Form
    {
        private static AgregarCliente frmInstance = null;
        Cliente clientesEntidad = new Cliente();
        ClientesNegocio clientesNegocio = new ClientesNegocio();
        private bool respuesta;
        private int clienteID;
        TextBox[] textBoxes;


        public static AgregarCliente Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new AgregarCliente();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public AgregarCliente()
        {
            InitializeComponent();
            textBoxes = new TextBox[] { txtNombre, txtCedulaORnc, txtDireccion, txtContacto1, txtContacto2, txtDescuento };
        }


        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Select();           

        }
     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarClientes buscarClientes = null;
            buscarClientes = BuscarClientes.Instance();            
            buscarClientes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampoCedula() && validarCampoContacto() && validarCampoNombre())
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea agregar nuevo cliente?", "Nuevo Cliente", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    clientesEntidad.Nombre = txtNombre.Text;
                    clientesEntidad.CedulaORnc = txtCedulaORnc.Text;
                    clientesEntidad.Direccion = txtDireccion.Text;
                    clientesEntidad.Contacto_1 = txtContacto1.Text;
                    clientesEntidad.Contacto_2 = txtContacto2.Text;

                    if (!string.IsNullOrEmpty(txtDescuento.Text))
                        clientesEntidad.Descuento = Convert.ToDouble(txtDescuento.Text);
                    else
                    {
                        clientesEntidad.Descuento = 0;
                    }

                    var result = clientesNegocio.AgregarCliente(clientesEntidad);

                    respuesta = result.Item1;
                    clienteID = result.Item2;
                    validarInsertCliente(respuesta, clienteID);

                }
            }
            else
            {
                MessageBox.Show("Por favor complete los campos con error.");
            }
        }
    
        
        private void validarInsertCliente(bool respuesta, int clienteID)
        {

            if (respuesta)
            {

                MessageBox.Show(string.Format("El cliente ha sido agregado correctamente a la base de datos, con el numero de cliente:{0}", clienteID), "Cliente Agregado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El cliente no pudo ser agregado a la base de datos, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in textBoxes)
            {
                txtBox.Clear();
            }
            txtNombre.Select();
        }

        private bool validarCampoNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProviderNombre.Icon = Properties.Resources.error;
                errorProviderNombre.SetError(txtNombre, "El Campo NOMBRE no puede estar vacio");
                return false;
            }
            else
            {
                errorProviderNombre.Icon = Properties.Resources.yes;
                errorProviderNombre.SetError(txtNombre, "Correcto!");
                return true;
            }
        }

        private bool validarCampoContacto()
        {
            if (string.IsNullOrEmpty(txtContacto1.Text))
            {
                errorProviderContacto1.Icon = Properties.Resources.error;
                errorProviderContacto1.SetError(txtContacto1, "El Campo Contacto no puede estar vacío o debe de tener valores numericos");
                return false;
            }
            else
            {
                errorProviderContacto1.Icon = Properties.Resources.yes;
                errorProviderContacto1.SetError(txtContacto1, "Correcto!");
                return true;
            }
        }

        private bool validarCampoCedula()
        {
            if (string.IsNullOrEmpty(txtCedulaORnc.Text))
            {
                errorProviderContacto1.Icon = Properties.Resources.error;
                errorProviderContacto1.SetError(txtCedulaORnc, "El Campo Contacto no puede estar vacío o debe de tener valores numericos");
                return false;
            }
            else
            {
                errorProviderContacto1.Icon = Properties.Resources.yes;
                errorProviderContacto1.SetError(txtCedulaORnc, "Correcto!");
                return true;
            }

        }

    }
}
