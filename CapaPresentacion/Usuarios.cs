using CapaDatos;
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

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        private static Usuarios frmInstance = null;
        List<proc_CargarTodosUsers_Result> proc_CargarTodosUsers_Results;
        UsersNegocio usersNegocio = new UsersNegocio();
        User userEntidad = new User();
        bool resultado;
        int userID;
        public static Usuarios Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new Usuarios();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public Usuarios()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }
        private void CargarDataGridView()
        {
            proc_CargarTodosUsers_Results = usersNegocio.CargarTodosUsers().ToList();
            dgvUsuarios.DataSource = proc_CargarTodosUsers_Results;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBoxs();
        }

        private void LlenarTextBoxs()
        {
            txtUsuarioID.Text = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value);
            txtUsername.Text = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[1].Value);
            txtPassword.Text = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[2].Value);
            txtLevel.Text = Convert.ToString(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[3].Value);
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            userEntidad.UserName = txtUsername.Text;
            userEntidad.UserPassword = txtPassword.Text;
            userEntidad.UserLevel = Convert.ToInt32(txtLevel.Text);
            var result = usersNegocio.AgregarUser(userEntidad);

            if (result.Item1)
            {
                MessageBox.Show(string.Format("El Usuario con codigo {0}, ha sido agregada correctamente", result.Item2.ToString()), "Usuario Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Usuario no pudo ser agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            userEntidad.UserID = Convert.ToInt32(txtUsuarioID.Text);
            userEntidad.UserName = txtUsername.Text;
            userEntidad.UserPassword = txtPassword.Text;
            userEntidad.UserLevel = Convert.ToInt32(txtLevel.Text);
            var result = usersNegocio.EditarUser(userEntidad);

            if (result)
            {
                MessageBox.Show("El Usuario ha sido editado correctamente", "Usuario Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Usuario no pudo ser editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            txtUsuarioID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtLevel.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(txtUsuarioID.Text);

            var result = usersNegocio.BorrarUser(userID);

            if (result)
            {
                MessageBox.Show("Usuario ha sido eliminado correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Usuario no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Selected = true;
            LlenarTextBoxs();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
