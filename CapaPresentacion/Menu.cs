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
using System.Data.Entity.Core.Objects;
using System.Threading;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        MenuNegocio menuNegocio = new MenuNegocio();
        FacturasNegocio facturasNegocio = new FacturasNegocio();
        Thread hilo;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                cargarMenu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
            
        }
        //identificando el nivel del usuario
        private void cargarMenu()
        {
            if (Login.userLevel == 1)
            {
                cargarMenuAdmin();
            }
            else
            {
                cargarMenuUser();
            }
        }
        //cargar menu completo a los que tienen niveles de administradores
        private void cargarMenuAdmin()
        {
            var resultadoMenu = menuNegocio.opcionesMenuAdminNE().ToList();
            var resultadoSubMenu = menuNegocio.opcionesSubMenuAdminNE().ToList();
            //recorrer los menu y submenu para colocarlos en donde corresponden
            foreach (var menu in resultadoMenu)
            {
                ToolStripMenuItem MnuStripItem = new ToolStripMenuItem();
                //texto del menu
                MnuStripItem.Text = menu.Menu.ToString();
                MnuStripItem.Click += MenuItemOnClick;
                int menuID = Convert.ToInt32(menu.MenuID.ToString());
                //se busca los submenu del menu actual
                var menuSubmenu = resultadoSubMenu
                             .Where(p => p.MenuID == menuID);
                


                foreach (var subMenu in menuSubmenu)
                {
                    ToolStripMenuItem subMnuStripItem = new ToolStripMenuItem();
                    //texto del submenu
                    subMnuStripItem.Text = subMenu.SubMenu;
                    subMnuStripItem.Click += MenuItemOnClick;
                    MnuStripItem.DropDownItems.Add(subMnuStripItem);

                }
                //agregar item(menu y submenu correspondiente) al menuStrip
                menuStrip.Items.Add(MnuStripItem);
            }
        }
        //metodo para cargar el menu completo a los que tienen nivel usuario
        public void cargarMenuUser()
            {
                var resultadoMenu = menuNegocio.opcionesMenuUserNE().ToList();
                var resultadoSubMenu = menuNegocio.opcionesSubMenuUserNE().ToList();
            //recorrer los menu y submenu para colocarlos en donde corresponden
            foreach (var menu in resultadoMenu)
            {
                ToolStripMenuItem MnuStripItem = new ToolStripMenuItem();
                //texto del menu
                MnuStripItem.Text = menu.Menu.ToString();
                MnuStripItem.Click += MenuItemOnClick;
                int menuID = Convert.ToInt32(menu.MenuID.ToString());
                //se busca los submenu del menu actual
                var menuSubmenu = resultadoSubMenu
                             .Where(p => p.MenuID == menuID);

                
                foreach (var subMenu in menuSubmenu)
                {
                    ToolStripMenuItem subMnuStripItem = new ToolStripMenuItem();
                    //texto del submenu
                    subMnuStripItem.Text = subMenu.SubMenu;
                    subMnuStripItem.Click += MenuItemOnClick;
                    MnuStripItem.DropDownItems.Add(subMnuStripItem);

                }
                //agregar item(menu y submenu correspondiente) al menuStrip
                menuStrip.Items.Add(MnuStripItem);
                
            }
        }
        private void MenuItemOnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            switch (menuItem.Text.ToString())
            {
                case "Salir":
                    this.Close();
                    return;
                case "Registrar Venta":
                    RegistrarVenta registrarVenta = null;                    
                    registrarVenta.MdiParent = this;
                    registrarVenta.Show();
                    return;
                case "Buscar Productos":
                    BuscarProductos buscarProductos = null;
                    buscarProductos = BuscarProductos.Instance();
                    buscarProductos.MdiParent = this;
                    buscarProductos.Show();
                    return;
                case "Buscar Clientes":
                    BuscarClientes buscarClientes = null;
                    buscarClientes = BuscarClientes.Instance();
                    buscarClientes.MdiParent = this;
                    buscarClientes.Show();
                    return;                
                case "Buscar Proveedor":
                    BuscarProveedores buscarProveedores = null;
                    buscarProveedores = BuscarProveedores.Instance();
                    buscarProveedores.MdiParent = this;
                    buscarProveedores.Show();
                    return;
                case "Agregar Cliente":
                    AgregarCliente agregarCliente = null;
                    agregarCliente = AgregarCliente.Instance();
                    agregarCliente.MdiParent = this;
                    agregarCliente.Show();
                    return;
                case "Agregar Producto":
                    AgregarProducto agregarProducto = null;
                    agregarProducto = AgregarProducto.Instance();
                    agregarProducto.MdiParent = this;
                    agregarProducto.Show();
                    return;
                case "Agregar Proveedor":
                    AgregarProveedor agregarProveedor = null;
                    agregarProveedor = AgregarProveedor.Instance();
                    agregarProveedor.MdiParent = this;
                    agregarProveedor.Show();
                    return;
                case "Configuracion":
                    Configuracion configuracion = null;
                    configuracion = Configuracion.Instance();
                    configuracion.MdiParent = this;
                    configuracion.Show();
                    return;
                case "Registrar Compra":
                    return;
                case "Imprimir Ultima Factura":
                    ComprobarTipoFactura();
                   
                    return;
                case "Categorias Productos":
                    Categorias categoriasProd = null;
                    categoriasProd = Categorias.Instance();
                    categoriasProd.MdiParent = this;
                    categoriasProd.Show();
                    return;
                case "Tipos de Pagos":
                    TiposDePago tiposDePago = null;
                    tiposDePago = TiposDePago.Instance();
                    tiposDePago.MdiParent = this;
                    tiposDePago.Show();
                    return;
                case "Tipos de Facturas":
                    TiposDeFacturas tiposDeFacturas = null;
                    tiposDeFacturas = TiposDeFacturas.Instance();
                    tiposDeFacturas.MdiParent = this;
                    tiposDeFacturas.Show();
                    return;
                case "Usuarios":
                    Usuarios usuarios = null;
                    usuarios = Usuarios.Instance();
                    usuarios.MdiParent = this;
                    usuarios.Show();
                    return;
                case "Ordenes de Compras":
                    OrdenesCompras ordenesCompras = null;
                    ordenesCompras = OrdenesCompras.Instance();
                    ordenesCompras.MdiParent = this;
                    ordenesCompras.Show();
                    return;
                case "Productos con existencia baja":
                    ProductosExistBaja productosExistBaja = null;
                    productosExistBaja = ProductosExistBaja.Instance();
                    productosExistBaja.MdiParent = this;
                    productosExistBaja.Show();
                    return;
                case "Lineas de credito ventas":
                    LineasCreditoVentas lineasCreditoVentas = null;
                    lineasCreditoVentas = LineasCreditoVentas.Instance();
                    lineasCreditoVentas.MdiParent = this;
                    lineasCreditoVentas.Show();
                    return;
                case "Notas de credito":
                    NotaDeCredito notaDeCredito = null;
                    notaDeCredito = NotaDeCredito.Instance();
                    notaDeCredito.MdiParent = this;
                    notaDeCredito.Show();
                    return;
                case "Buscar notas de credito":
                    BuscarNotasDeCredito buscarNotasDeCredito = null;
                    buscarNotasDeCredito = BuscarNotasDeCredito.Instance();
                    buscarNotasDeCredito.MdiParent = this;
                    buscarNotasDeCredito.Show();
                    return;
                case "Buscar facturas":
                    BuscarFacturasVenta buscarFacturasVenta = null;
                    buscarFacturasVenta = BuscarFacturasVenta.Instance();
                    buscarFacturasVenta.MdiParent = this;
                    buscarFacturasVenta.Show();
                    return;
                case "Imprimir ordenes de compra":
                    RangoFechaPedidosProveedor rangoFechaPedidosProveedor = null;
                    rangoFechaPedidosProveedor = RangoFechaPedidosProveedor.Instance();
                    rangoFechaPedidosProveedor.MdiParent = this;
                    rangoFechaPedidosProveedor.Show();
                    return;
                case "Calcular Ganancias":
                    ImprimirGanancias imprimirGanancias = null;
                    imprimirGanancias = ImprimirGanancias.Instance();
                    imprimirGanancias.MdiParent = this;
                    imprimirGanancias.Show();
                    return;
                case "Imprimir lineas de credito":
                    RangoFechasLCreditoVenta rangoFechasLCreditoVenta = null;
                    rangoFechasLCreditoVenta = RangoFechasLCreditoVenta.Instance();
                    rangoFechasLCreditoVenta.MdiParent = this;
                    rangoFechasLCreditoVenta.Show();
                    return;
                case "Imprimir los 10 productos mas vendidos":
                    RangoFecha10ProdMasVendidos rangoFecha10ProdMasVendidos = null;
                    rangoFecha10ProdMasVendidos = RangoFecha10ProdMasVendidos.Instance();
                    rangoFecha10ProdMasVendidos.MdiParent = this;
                    rangoFecha10ProdMasVendidos.Show();
                    return;
                case "Imprimir facturas de venta":
                    RangoFechaFacturas rangoFechaFacturas = null;
                    rangoFechaFacturas = RangoFechaFacturas.Instance();
                    rangoFechaFacturas.MdiParent = this;
                    rangoFechaFacturas.Show();
                    return;
                case "Imprimir notas de credito venta":
                    RangoFechaNotasCreditoPFecha rangoFechaNotasCreditoPFecha = null;
                    rangoFechaNotasCreditoPFecha = RangoFechaNotasCreditoPFecha.Instance();
                    rangoFechaNotasCreditoPFecha.MdiParent = this;
                    rangoFechaNotasCreditoPFecha.Show();
                    return;
                default:
                    break;
            }
        }

        private void ComprobarTipoFactura()
        {
            var result = facturasNegocio.VerTipoUltimaFactura().FirstOrDefault();
            CreacionThreadImpresora(result.TipoFacturaID);
        }

        private void CreacionThreadImpresora(int tipoFactura)
        {
            //Creamos la instancia del hilo 
            hilo = new Thread(() => ImprimirUltimaFactura(tipoFactura));
            //Iniciamos el hilo 
            hilo.Start();
        }
        private void ImprimirUltimaFactura(int tipoFactura)
        { 
            switch (tipoFactura)
            {
                case 1:
                    ReporteDetalleFactura reporteDetalleFactura = null;
                    reporteDetalleFactura = ReporteDetalleFactura.Instance();                    
                    reporteDetalleFactura.Visible = false;
                    reporteDetalleFactura.Show();
                    break;
                case 2:
                    ReporteDetalleFacturaFiscal reporteDetalleFacturaFiscal = null;
                    reporteDetalleFacturaFiscal = ReporteDetalleFacturaFiscal.Instance();                    
                    reporteDetalleFacturaFiscal.Visible = false;
                    reporteDetalleFacturaFiscal.Show();
                    break;
                default:
                    break;
            }
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //confirmar cierre del formulario
            if (MessageBox.Show("¿Seguro que desea salir?",
                       "Salida",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
       
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cuando este formulario se cierra, se cierra la aplicacion completa
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        
        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            BuscarClientes buscarClientes = null;
            buscarClientes = BuscarClientes.Instance();
            buscarClientes.MdiParent = this;
            buscarClientes.Show();
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            BuscarProductos buscarProductos = null;
            buscarProductos = BuscarProductos.Instance();
            buscarProductos.MdiParent = this;
            buscarProductos.Show();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            RegistrarVenta registrarVenta = null;           
            registrarVenta.MdiParent = this;
            registrarVenta.Show();
        }

        private void btnBuscarProveedores_Click(object sender, EventArgs e)
        {
            BuscarProveedores buscarProveedores = null;
            buscarProveedores = BuscarProveedores.Instance();
            buscarProveedores.MdiParent = this;
            buscarProveedores.Show();
        }
    }
 }
    
    
