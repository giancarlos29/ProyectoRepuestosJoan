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
    public partial class DetallesOrdenCompra : Form
    {
        private static DetallesOrdenCompra frmInstance = null;
        public static bool verificarSeleccionProducto, verificarModCant, verificarModPrecio, verificarModCantRecibida = false;
        public static bool abiertoDesdeBuscarProveedorForm, abiertoDesdeOrdenesCompraForm;
        private bool existe = false;
        public static int proveedorID;
        ProveedoresNegocio proveedoresNegocio = new ProveedoresNegocio();
        public static double cantidad, cantRecibida;
        public static decimal precio;
        private int ordenCompraID;
        
        OrdenesCompra ordenCompraEntidad = new OrdenesCompra();
        OrdenesCompraNegocio ordenesCompraNegocio = new OrdenesCompraNegocio();
        DetalleOrdenCompraNegocio detalleOrdenCompraNegocio = new DetalleOrdenCompraNegocio();
        DetalleOrdenesCompra detalleOrdenCompraEntidad = new DetalleOrdenesCompra();
        List<proc_CargarDetalleOrdenCompra_Result> proc_CargarDetalleOrdenCompra_Results;
        proc_CargarDetalleOrdenCompra_Result Proc_CargarDetalleOrdenCompra_Result = new proc_CargarDetalleOrdenCompra_Result();



        public static DetallesOrdenCompra Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new DetallesOrdenCompra();
            }
            else
            {
                frmInstance.BringToFront();
            }
            return frmInstance;
        }

        public DetallesOrdenCompra()
        {
            InitializeComponent();
        }

       

        private void btnCompra_Click(object sender, EventArgs e)
        {
            proveedorID = Convert.ToInt32(txtCodProveedor.Text);
            AbrirFormBuscarProdPorProveedor();
            
        }

        private void AbrirFormBuscarProdPorProveedor()
        {
            ProductosPorProveedor productosPorProveedor = null;
            productosPorProveedor = ProductosPorProveedor.Instance();
            productosPorProveedor.ShowDialog();
            VerificarSeleccionProducto();
        }

        private void DetallesOrdenCompra_Load(object sender, EventArgs e)
        {
            VerificarDesdeQueFormSeAbrio();            
        }

        private void CargarDataGridView()
        {
            proc_CargarDetalleOrdenCompra_Results = detalleOrdenCompraNegocio.CargarDetalleOrdenCompra(OrdenesCompras.ordenCompraID).ToList();
            foreach (proc_CargarDetalleOrdenCompra_Result list in proc_CargarDetalleOrdenCompra_Results)
            {
                dgvProductos.Rows.Add(list.ProductoID,list.Referencia,list.Descripcion,list.Calidad,list.Existencia
                    ,list.CantMin, list.CantidadOrdenada,list.CantidadRecibida,list.Precio);

            }
        }

        private void VerificarDesdeQueFormSeAbrio()
        {
            if (abiertoDesdeBuscarProveedorForm)
            {
                LlenarTextBox(BuscarProveedores.proveedorID);
                btnRecibirTodo.Enabled = false;
                btnRecibir.Enabled = false;
                
            }

            if (abiertoDesdeOrdenesCompraForm)
            {
                CargarDataGridView();
                LlenarTextBox(OrdenesCompras.proveedorID);
                txtOrdenCompraID.Text = Convert.ToString(OrdenesCompras.ordenCompraID);
                
            }
        }

        private void LlenarTextBox(int proveedorID)
        {
            var result = proveedoresNegocio.BuscarProveedoresPorID(proveedorID).FirstOrDefault();
            txtCodProveedor.Text = proveedorID.ToString();
            txtNomProveedor.Text = result.Nombre;            
        }

       private void AgregarProductosAlDgv()
        {
            
            foreach (DataRow dtRow in ProductosPorProveedor.dtProductosMarcados.Rows)
            {
                existe = false;

                foreach (DataGridViewRow dgvRow in dgvProductos.Rows)
                {
                    if (dtRow[0].Equals(dgvRow.Cells[0].Value))
                       existe = true;                    
                }

                if (!existe)
                {
                    dgvProductos.Rows.Add(dtRow[0], dtRow[1], 
                        dtRow[2], dtRow[3], dtRow[4], dtRow[5], (Convert.ToDouble(dtRow[6]) - Convert.ToDouble(dtRow[4])), 0,dtRow[7]);
           
                }             
            }          
        }

        private void DetallesOrdenCompra_Activated(object sender, EventArgs e)
        {        
            
            
        }

        private void VerificarSeleccionProducto()
        {
            if (verificarSeleccionProducto)
            {
                AgregarProductosAlDgv();
                verificarSeleccionProducto = false;
            }
        }
        private void VerificarModCant()
        {
            if (verificarModCant)
            {
                dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[6].Value = ModificarCantidad.cantidad;
                verificarModCant = false;
            }
        }
        private void VerificarModPrecio()
        {
            if (verificarModPrecio)
            {
                dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[8].Value = ModificarPrecio.precio;
                verificarModPrecio = false;
            }
        }
        private void VerificarModCantRecibida()
        {
            if (verificarModCantRecibida)
            {
                dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[7].Value = ModificarCantRecibida.cantRecibida;
                verificarModCantRecibida = false;
            }
        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {            
            EliminarDetalleProdSiExiste();
        }

        private void EliminarDetalleProdSiExiste()
        {
            if (abiertoDesdeOrdenesCompraForm)
            {
                detalleOrdenCompraEntidad.OrdenCompraID = Convert.ToInt32(txtOrdenCompraID.Text);
                detalleOrdenCompraEntidad.ProductoID = Convert.ToInt32(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value);
                var result = detalleOrdenCompraNegocio.BorrarDetalleOrdenCompra(detalleOrdenCompraEntidad);
                QuitarProdDeLista(result);
                
            }

            if (abiertoDesdeBuscarProveedorForm)
                QuitarProdDeLista(true);
        }

        private void QuitarProdDeLista(bool result)
        {
            if (result)
            {
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
                MessageBox.Show("Producto eliminado de la lista correctamente", "Eliminado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Producto no pudo ser quitado de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            CargarVariableCantidad();
            CargarFormModCantidad();
            
        }

        private void CargarFormModCantidad()
        {
            ModificarCantidad modificarCantidad = null;
            modificarCantidad = ModificarCantidad.Instance();
            modificarCantidad.ShowDialog();
            VerificarModCant();           
        }

        private void CargarVariableCantRecibida()
        {
            cantRecibida = Convert.ToDouble(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[7].Value);
        }

        private void CargarVariableCantidad()
        {
            cantidad = Convert.ToDouble(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[6].Value);
        }

        private void btnCosto_Click(object sender, EventArgs e)
        {
            CargarVariablePrecio();
            CargarFormModPrecio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            VerificarDesdeQueFormSeAbrioParaBtnGuardar();
        }
        private void VerificarDesdeQueFormSeAbrioParaBtnGuardar()
        {
            if (abiertoDesdeBuscarProveedorForm)
            {
                CreacionOrdenCompra();
                
               
            }

            if (abiertoDesdeOrdenesCompraForm)
            {
                ActualizacionDetalleOrdenCompra();
                
            }
        }

        private void ActualizacionDetalleOrdenCompra()
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                detalleOrdenCompraEntidad.OrdenCompraID = Convert.ToInt32(txtOrdenCompraID.Text);
                detalleOrdenCompraEntidad.ProductoID = Convert.ToInt32(row.Cells[0].Value);
                detalleOrdenCompraEntidad.CantidadOrdenada = Convert.ToDouble(row.Cells[6].Value);
                detalleOrdenCompraEntidad.CantidadRecibida = Convert.ToDouble(row.Cells[7].Value);
                detalleOrdenCompraEntidad.Precio = Convert.ToDecimal(row.Cells[8].Value);

                var result = detalleOrdenCompraNegocio.ActualizarDetalleOrdenCompra(detalleOrdenCompraEntidad);

                ResultadoActualizacion(result);
            }
                   
        }

        private void ResultadoActualizacion (bool result)
        {
            if (result)
                MessageBox.Show(string.Format("Orden #{0} Actualizada Correctamente",txtOrdenCompraID.Text), "Actualizacion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreacionOrdenCompra()
        {
            ordenCompraEntidad.ProveedorID = Convert.ToInt32(txtCodProveedor.Text);
            ordenCompraEntidad.FechaPedido = DateTime.Now;
            ordenCompraEntidad.Estatus = false;

            var result = ordenesCompraNegocio.InsertarOrdenCompra(ordenCompraEntidad);

            if (result.Item1)
            {
                MessageBox.Show(string.Format("Orden de compra #{0} fue creada satifastoriamente",result.Item2), "Orden Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ordenCompraID = result.Item2;
                CreacionDetalleOrdenCompra();
            }
            else
            {
                MessageBox.Show("Orden no pudo ser creada", "Error Orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CreacionDetalleOrdenCompra()
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                detalleOrdenCompraEntidad.OrdenCompraID = ordenCompraID;
                detalleOrdenCompraEntidad.ProductoID = Convert.ToInt32(row.Cells[0].Value);
                detalleOrdenCompraEntidad.CantidadOrdenada = Convert.ToDouble(row.Cells[6].Value);
                detalleOrdenCompraEntidad.Precio = Convert.ToDecimal(row.Cells[8].Value);

                var result = detalleOrdenCompraNegocio.InsertarDetalleOrdenCompra(detalleOrdenCompraEntidad);
                MessageBox.Show(result.Item1.ToString());
            }
        }

        private void btnRecibirTodo_Click(object sender, EventArgs e)
        {
            if (abiertoDesdeOrdenesCompraForm)
                LlenarCamposCantidadRecibida();
        }

        private void LlenarCamposCantidadRecibida()
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if(row.Cells[7].Value == null)
                row.Cells[7].Value = row.Cells[6].Value;
            }
        }

        private void DetallesOrdenCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            abiertoDesdeBuscarProveedorForm = false;
            abiertoDesdeOrdenesCompraForm = false;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.Rows[dgvProductos.CurrentRow.Index].Selected = true;
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            CargarVariableCantRecibida();
            CargarFormModCantidadRecibida();
        }

        private void CargarFormModCantidadRecibida()
        {
            ModificarCantRecibida modificarCantRecibida = null;
            modificarCantRecibida = ModificarCantRecibida.Instance();            
            modificarCantRecibida.ShowDialog();
            VerificarModCantRecibida();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarFormModPrecio()
        {
            ModificarPrecio modificarPrecio = null;
            modificarPrecio = ModificarPrecio.Instance();            
            modificarPrecio.ShowDialog();
            VerificarModPrecio();
        }

        private void CargarVariablePrecio()
        {
            precio = Convert.ToDecimal(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[8].Value);
        }

    }
}
