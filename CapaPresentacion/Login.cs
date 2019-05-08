using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Login : Form
    {   
        
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        UsersNegocio metodosNegocios = new UsersNegocio();
        User usersEntidad = new User();
        bool respuesta;
        public static int userLevel;
        public static int userID;
                
        public Login()
        {
            InitializeComponent();
        }

        private void Validar()
        {
            
            usersEntidad.UserName = txtUserName.Text;
            usersEntidad.UserPassword = txtUserPassword.Text;
            //se verifica el usuario
            var resultado = metodosNegocios.ValidarUsuario(usersEntidad);
            respuesta = resultado.Item1;

            if (resultado.Item2 != null)
            {
                userID = resultado.Item2.UserID;
                userLevel = resultado.Item2.UserLevel;
            }

            if (respuesta)
            {
                MessageBox.Show("Usuario ingresado correctamente.", "Bienvenido",MessageBoxButtons.OK);
                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.Show();                
            }
            else
            {
                MessageBox.Show("Usuario incorecto, intente nuevamente...", "Error", MessageBoxButtons.OK);
                txtUserPassword.Clear();
                txtUserName.Clear();
                txtUserName.Select();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
            //cuando el user presione enter, simulara un click en ese boton
            this.AcceptButton = btnAceptar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
