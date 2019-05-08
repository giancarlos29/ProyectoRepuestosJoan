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
    public partial class AgregarProveedor : Form
    {
        private static AgregarProveedor frmInstance = null;
        Proveedore proveedorEntidad = new Proveedore();
        ProveedoresNegocio proveedorNegocio = new ProveedoresNegocio();
        private bool respuesta;
        private int proveedorID;
        TextBox[] textBoxes;


        public static AgregarProveedor Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new AgregarProveedor();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public AgregarProveedor()
        {
            InitializeComponent();
            textBoxes = new TextBox[] { txtNombre, txtCedulaORnc, txtDireccion, txtContacto1, txtContacto2, txtDatoAdicional };
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

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {
            txtNombre.Select();           
        }
       
        private void btnBuscarProveedores_Click(object sender, EventArgs e)
        {
            BuscarProveedores buscarProveedores = null;
            buscarProveedores = BuscarProveedores.Instance();
            buscarProveedores.MdiParent = this.MdiParent;
            buscarProveedores.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (validarCampoContacto() && validarCampoNombre())
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea agregar" +
                    " nuevo proveedor a la base de datos?", "Nuevo Proveedor", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    proveedorEntidad.Nombre = txtNombre.Text;
                    proveedorEntidad.CedulaORnc = txtCedulaORnc.Text;
                    proveedorEntidad.Direccion = txtDireccion.Text;
                    proveedorEntidad.Contacto_1 = txtContacto1.Text;
                    proveedorEntidad.Contacto_2 = txtContacto2.Text;
                    proveedorEntidad.DatoAdicional = txtDatoAdicional.Text;


                    var result = proveedorNegocio.AgregarProveedor(proveedorEntidad);

                    respuesta = result.Item1;
                    proveedorID = result.Item2;
                    validarInsertProveedor(respuesta, proveedorID);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete los campos con error.");
            }
        }
        private void validarInsertProveedor(bool respuesta, int proveedorID)
        {

            if (respuesta)
            {
                MessageBox.Show(string.Format("El proveedor ha sido agregado correctamente a la base de datos, con el numero de proveedor:{0}", proveedorID), "Proveedor Agregado Correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El proveedor no pudo ser agregado a la base de datos, favor de verificar los requerimientros", "Ha Ocurrido un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
