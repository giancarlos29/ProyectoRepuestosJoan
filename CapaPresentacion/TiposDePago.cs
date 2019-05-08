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
    public partial class TiposDePago : Form
    {
        private static TiposDePago frmInstance = null;
        List<proc_CargarTodosTiposPagos_Result> proc_CargarTodosTiposPagos_Results;
        TiposPagosNegocio tiposPagosNegocio = new TiposPagosNegocio();
        TiposPago tiposPagoEntidad = new TiposPago();
        bool resultado;
        int tipoPagoId;
        public static TiposDePago Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new TiposDePago();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public TiposDePago()
        {
            InitializeComponent();
        }

        private void TiposDePago_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }
        private void CargarDataGridView()
        {
            proc_CargarTodosTiposPagos_Results = tiposPagosNegocio.CargarTodosTiposPagos().ToList();
            dgvTiposPagos.DataSource = proc_CargarTodosTiposPagos_Results;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBoxs();
        }

        private void LlenarTextBoxs()
        {
            txtIDPago.Text = Convert.ToString(dgvTiposPagos.Rows[dgvTiposPagos.CurrentRow.Index].Cells[0].Value);
            txtTipoDePago.Text = Convert.ToString(dgvTiposPagos.Rows[dgvTiposPagos.CurrentRow.Index].Cells[1].Value);
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBoxs();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tiposPagoEntidad.TipoDePago = txtTipoDePago.Text;
            var result = tiposPagosNegocio.AgregarTipoPago(tiposPagoEntidad);

            if (result.Item1)
            {
                MessageBox.Show(string.Format("El Tipo de Pago con codigo {0}, ha sido agregada correctamente", result.Item2.ToString()), "Tipo de Pago Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Tipo de Pago no pudo ser agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tiposPagoEntidad.TipoPagoID = Convert.ToInt32(txtIDPago.Text);
            tiposPagoEntidad.TipoDePago = txtTipoDePago.Text;
            var result = tiposPagosNegocio.EditarTipoPago(tiposPagoEntidad);

            if (result)
            {
                MessageBox.Show("El Tipo de Pago ha sido editado correctamente", "Tipo de Pago Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Tipo de Tipo no pudo ser editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }
        private void LimpiarTxt()
        {
            txtIDPago.Clear();
            txtTipoDePago.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tipoPagoId = Convert.ToInt32(txtIDPago.Text);

            var result = tiposPagosNegocio.BorrarTipoPago(tipoPagoId);

            if (result)
            {
                MessageBox.Show("El Tipo de Pago ha sido eliminado correctamente", "Tipo de Pago Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridView();
            }
            else
                MessageBox.Show("Tipo de Pago no pudo ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarTxt();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTiposPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTiposPagos.Rows[dgvTiposPagos.CurrentRow.Index].Selected = true;
        }
    }

}