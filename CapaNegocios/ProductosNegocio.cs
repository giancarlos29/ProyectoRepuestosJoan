using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity.Core.Objects;

namespace CapaNegocios
{
     public class ProductosNegocio
     {
        ProductosDatos productosDatos = new ProductosDatos();
        public Tuple<bool, int> AgregarProducto(Producto producto)
        {

            return productosDatos.AgregarProducto(producto);
        }

        public ObjectResult<proc_CargarTodosProductos_Result> CargarTodosProductos()
        {
            return productosDatos.CargarTodosProductos();
        }
        public ObjectResult<proc_CargarProductosExistBaja_Result> CargarProductosExistBaja()
        {
            return productosDatos.CargarProductosExistBaja();
        }

        public ObjectResult<proc_CargarProductosExistBajaPorProveedor_Result> CargarProductosExistBajaPorProveedor(int proveedorID)
        {
            return productosDatos.CargarProductosExistBajaPorProveedor(proveedorID);
        }


        public ObjectResult<proc_BuscarProductosPorID_Result> BuscarProductosPorID(int productoID)
        {
            return productosDatos.BuscarProductosPorID(productoID);
        }

        public ObjectResult<proc_BuscarProductosPorProveedor_Result> BuscarProductosPorProveedor(int proveedorID)
        {
            return productosDatos.BuscarProductosPorProveedor(proveedorID);
        }

        public ObjectResult<proc_BuscarProductosPorCodigoBarra_Result> BuscarProductosPorCodigoBarra(string codigoBarra)
        {
            return productosDatos.BuscarProductosPorCodigoBarra(codigoBarra);
        }

        public ObjectResult<proc_BuscarCantidadProductosPorCodigoBarra_Result> BuscarCantidadProductosPorCodigoBarra(string codigoBarra)
        {
            return productosDatos.BuscarCantidadProductosPorCodigoBarra(codigoBarra);
        }

        public bool EditarProducto(Producto producto)
        {
            return productosDatos.EditarProducto(producto);
        }

        public bool ActualizarCantidadProducto(Producto producto)
        {
            return productosDatos.ActualizarCantidadProducto(producto);
        }

        public bool BorrarProducto(int productoID)
        {
            return productosDatos.BorrarProducto(productoID);
        }

        public ObjectResult<proc_Cargar10ProductosVendidosPFecha_Result> Cargar10ProductosVendidosPFecha(DateTime fInicial, DateTime fFinal)
        {
            return productosDatos.Cargar10ProductosVendidosPFecha(fInicial, fFinal);
        }
    }
}
