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
    public partial class BuscarClientes : Form
    {
        private static BuscarClientes frmInstance = null;
        ClientesNegocio clientesNegocio = new ClientesNegocio();
        List<proc_CargarTodosClientes_Result> proc_CargarTodosClientes_Results;
        public static int clienteID;
        Cliente clientesEntidad = new Cliente();
        public static bool verificar = false;
        
        

        public static BuscarClientes Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new BuscarClientes();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            proc_CargarTodosClientes_Results = clientesNegocio.CargarTodosClientes().ToList();
            dgvClientes.DataSource = proc_CargarTodosClientes_Results;


        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            clienteID = (int) dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value;
            
            EditarCliente editarCliente = null;
            editarCliente = EditarCliente.Instance();            
            editarCliente.ShowDialog();
            ValidarCambiosEditarCliente();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(rbtnNombre.Checked == true)
                dgvClientes.DataSource = proc_CargarTodosClientes_Results.Where(p => p.Nombre.Contains(txtBuscar.Text)).ToList();
            if (rbtnCedulaORnc.Checked == true)
                dgvClientes.DataSource = proc_CargarTodosClientes_Results.Where(p => p.CedulaORnc.Contains(txtBuscar.Text)).ToList();
            if (rbtnCodigo.Checked == true)
                dgvClientes.DataSource = proc_CargarTodosClientes_Results.Where(p => p.ClienteID.ToString().Contains(txtBuscar.Text)).ToList();
        }

        private void ValidarCambiosEditarCliente() 
        {
            if (verificar)
            {
                CargarDataGridView();
                verificar = false;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            clienteID = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            RegistrarVenta registrarVenta = new RegistrarVenta();            
            registrarVenta.MdiParent = this.MdiParent;
            registrarVenta.Show();
            this.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.Rows[dgvClientes.CurrentRow.Index].Selected = true;
        }
    }
}
