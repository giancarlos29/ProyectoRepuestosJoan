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
    public partial class Categorias : Form
    {
        private static Categorias frmInstance = null;
        List<proc_CargarTodasCategoriasProd_Result> proc_CargarTodasCategoriasProd_Results;
        CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
        CategoriasProd categoriasEntidad = new CategoriasProd();
        bool resultado;
        int categoriaId;
        public static Categorias Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new Categorias();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CargarDataGridView();

        }

        private void CargarDataGridView()
        {
            proc_CargarTodasCategoriasProd_Results = categoriasNegocio.CargarCategoriasProd().ToList();
            dgvCategorias.DataSource = proc_CargarTodasCategoriasProd_Results;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBoxs();
        }

        private void LlenarTextBoxs()
        {
            txtCategoriaID.Text = Convert.ToString(dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[0].Value);
            txtNombreCategoria.Text = Convert.ToString(dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[1].Value);

        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Selected = true;
            LlenarTextBoxs();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            categoriasEntidad.Categoria = txtNombreCategoria.Text;
            var result = categoriasNegocio.AgregarCategoriaProd(categoriasEntidad);

            if (result.Item1)
            { 
                MessageBox.Show(string.Format("La categoria con codigo {0}, ha sido agregada correctamente", result.Item2.ToString()), "Categoria Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
        }
            else
                MessageBox.Show("Categoria no pudo ser agregada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            categoriasEntidad.CategoriaProdID = Convert.ToInt32(txtCategoriaID.Text);
            categoriasEntidad.Categoria = txtNombreCategoria.Text;
            var result = categoriasNegocio.EditarCategoriaProd(categoriasEntidad);

            if (result)
            {
                MessageBox.Show("La categoria ha sido editada correctamente", "Categoria Editada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Categoria no pudo ser editada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
    }
        private void LimpiarTxt()
        {
            txtCategoriaID.Clear();
            txtNombreCategoria.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            categoriaId = Convert.ToInt32(txtCategoriaID.Text);
            
            var result = categoriasNegocio.BorrarCategoriaProd(categoriaId);

            if (result)
            {
                MessageBox.Show("La categoria ha sido eliminada correctamente", "Categoria Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Categoria no pudo ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
