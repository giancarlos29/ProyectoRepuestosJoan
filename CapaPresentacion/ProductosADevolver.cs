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
    public partial class ProductosADevolver : Form
    {
        public static double cantVen, cantRecibida, cantProductosRecibidos;
        public static decimal valorProdRecibidos;
        public static int productoID;
        public static bool verificarRecibirProducto, verificarInventariarProducto;
        private static ProductosADevolver frmInstance = null;
        FacturasNegocio facturasNegocio = new FacturasNegocio();
        public static DataTable dtProductosRecibidos, dtProductosFactura;
        private bool existe;
        

        public static ProductosADevolver Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new ProductosADevolver();
            }
            else
            {
                frmInstance.BringToFront();

            }
            return frmInstance;
        }

        public ProductosADevolver()
        {
            InitializeComponent();
        }

        private void ProductosADevolver_Load(object sender, EventArgs e)
        {
            VerificarDT();
            txtComentario.Clear();
            txtBuscar.Focus();
            
        }

        private void VerificarDT()
        {
            if(dtProductosRecibidos == null)
            {
                CargarDGV();                
                InicializarDataTableProdRecibidos();
                InicializarDataTableProdFactura();
            }
            else
            {
                if(dgvProductos.Columns.Count < 8)
                AgregarColumnasDgv();
                AgregarProductosAlDgv();
               
                

            }
                AdjustarOrdenColumnas();
        }

        private void AgregarProductosAlDgv()
        {
            
            foreach (DataRow dtRow in dtProductosFactura.Rows)
            {
                existe = false;

                foreach (DataGridViewRow dgvRow in dgvProductos.Rows)
                {
                    if (dtRow[7].Equals(dgvRow.Cells[7].Value))
                        existe = true;
                }

                if (!existe)
                {
                    dgvProductos.Rows.Add(dtRow[0], dtRow[1],
                        dtRow[2], dtRow[3], dtRow[4], dtRow[6], dtRow[5],dtRow[7]);

                }
            }
        }

        private void CargarDGV()

        {
            var result = facturasNegocio.CargarProductosFactura(NotaDeCredito.numeroFactura).ToList();
        
            if (result != null)
            dgvProductos.DataSource = result;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            LimpiarDgvProductos();
            this.Close();
        }

        private void LimpiarDgvProductos()
        {
            dgvProductos.DataSource = null;
        }

        private void btnInventariar_Click(object sender, EventArgs e)
        {
            if (ConfirmarCantRecibida())
            {                
                LlamarFormInventariarProd();
            }
            else
            {
                MessageBox.Show("Cantidad Recibida no puede estar vacia...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private bool ConfirmarCantRecibida()
        {
           CargarVariableCantRecibida();
            if (cantRecibida != 0)
                return true;
            else
                return false;

        }

        private void CargarVariableCantRecibida()
        {
            cantRecibida = Convert.ToDouble(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value);
        }

        private void CargarVariableCantVen()
        {
            productoID = Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[7].Value);
            cantVen = Convert.ToDouble(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[6].Value);

        }

        private void LlamarFormInventariarProd()
        {
            InventariarProducto inventariarProducto = null;
            inventariarProducto = InventariarProducto.Instance();
            inventariarProducto.ShowDialog();
            if (verificarInventariarProducto)
            {
                ModificarCantidadInventariada();
            }
        }

        private void ModificarCantidadInventariada()
        {
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value = InventariarProducto.cantInventariada;
            verificarInventariarProducto = false;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Selected = true;
            CargarTxtComentario();
        }

        private void CargarTxtComentario()
        {
            txtComentario.Text = Convert.ToString(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value);
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {

            if (ConfirmarCantVendida())
            {
                LlamarFormRecibirProd();

            }
            else
            {
                MessageBox.Show("Cantidad Vendida no puede estar vacia...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmarCantVendida()
        {
            CargarVariableCantVen();
            if (cantVen != 0)
                return true;
            else
                return false;
        }        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarDTProductosRecibidos();
            NotaDeCredito.verificarProductosADevolver = true;
            LimpiarDgvProductos();
            this.Close();
        }        

        private void InicializarDataTableProdRecibidos()
        {
            dtProductosRecibidos = new DataTable();
            dtProductosRecibidos.Columns.Add("ProductoID", typeof(int));            
            dtProductosRecibidos.Columns.Add("Precio", typeof(decimal));           
            dtProductosRecibidos.Columns.Add("Recibida", typeof(double));
            dtProductosRecibidos.Columns.Add("Inventariada", typeof(double));
            dtProductosRecibidos.Columns.Add("Comentario", typeof(string));
        }
        private void InicializarDataTableProdFactura()
        {
            dtProductosFactura = new DataTable();
            dtProductosFactura.Columns.Add("Recibida", typeof(double));
            dtProductosFactura.Columns.Add("Inventariada", typeof(double));
            dtProductosFactura.Columns.Add("Comentario", typeof(string));            
            dtProductosFactura.Columns.Add("Referencia", typeof(string));
            dtProductosFactura.Columns.Add("Descripcion", typeof(string));
            dtProductosFactura.Columns.Add("Precio", typeof(decimal));
            dtProductosFactura.Columns.Add("Vendida", typeof(double));            
            dtProductosFactura.Columns.Add("ID", typeof(int));

        }

        private void AgregarColumnasDgv()
        {            
            
            dgvProductos.Columns.Add("Referencia", "Referencia");
            dgvProductos.Columns.Add("Descripcion", "Descripcion");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("CantVend", "Vendida");            
            dgvProductos.Columns.Add("ID", "ID");
        }
        private void AdjustarOrdenColumnas()
        {            
            dgvProductos.Columns["ID"].DisplayIndex = 0;
            dgvProductos.Columns["Referencia"].DisplayIndex = 1;
            dgvProductos.Columns["Descripcion"].DisplayIndex = 2;
            dgvProductos.Columns["CantVend"].DisplayIndex = 3;
            dgvProductos.Columns["Precio"].DisplayIndex = 4;
            dgvProductos.Columns["Recibida"].DisplayIndex = 5;
            dgvProductos.Columns["Inventariada"].DisplayIndex = 6;
            dgvProductos.Columns["Comentario"].DisplayIndex = 7;
            dgvProductos.Columns["Comentario"].Visible = false;
        }


        private void CargarDTProductosRecibidos()
        {
            
            cantProductosRecibidos = 0;
            valorProdRecibidos = 0;
            
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                 dtProductosFactura.Rows.Add(Convert.ToDouble(row.Cells[0].Value)
                        , Convert.ToDouble(row.Cells[1].Value ?? 0)
                        , Convert.ToString(row.Cells[2].Value)                        
                        , Convert.ToString(row.Cells[3].Value)
                        , Convert.ToString(row.Cells[4].Value)
                        , Convert.ToDouble(row.Cells[6].Value)
                        , Convert.ToDecimal(row.Cells[5].Value) 
                        , Convert.ToInt32(row.Cells[7].Value));
                        

                if (row.Cells[0].Value != null && Convert.ToDouble(row.Cells[0].Value) != 0)
                {
                    dtProductosRecibidos.Rows.Add(Convert.ToInt32(row.Cells[7].Value)                       
                        , Convert.ToDecimal(row.Cells[5].Value)
                        , Convert.ToDouble(row.Cells[0].Value)
                        , Convert.ToDouble(row.Cells[1].Value)                        
                        , Convert.ToString(row.Cells[2].Value));

                    cantProductosRecibidos++;
                    valorProdRecibidos = valorProdRecibidos + (Convert.ToDecimal(row.Cells[5].Value) * Convert.ToDecimal(row.Cells[0].Value));

                }
            }
        }
        
        private void LlamarFormRecibirProd()
        {
            RecibirProducto recibirProducto = null;
            recibirProducto = RecibirProducto.Instance();
            recibirProducto.ShowDialog();
            if (verificarRecibirProducto)
            {
                ModificarCantidadRecibida();
                CargarTxtComentario();
                
            }            
        }

        private void ModificarCantidadRecibida()
        {
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value = RecibirProducto.cantRecibida;
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value = RecibirProducto.comentario;
            
            verificarRecibirProducto = false;
        }
    }
}
