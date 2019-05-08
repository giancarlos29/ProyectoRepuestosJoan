using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace CapaDatos
{
    public class ProductosDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter productoID = new ObjectParameter("ProductoID", typeof(int));

        public Tuple<bool, int> AgregarProducto(Producto producto)
        {
            modelDB.proc_InsertarProducto(productoID,producto.Descripcion, producto.Referencia, producto.CategoriaID, producto.Marca, producto.Existencia, producto.PrecioCompra, producto.PrecioVenta, producto.ProveedorID, producto.CodigoBarra, producto.Calidad, producto.ITBIS, producto.Descuento, producto.CantMin, producto.CantMax ,resultado);

            return Tuple.Create((bool)resultado.Value, (int)productoID.Value);
        }
        public ObjectResult<proc_CargarTodosProductos_Result> CargarTodosProductos()
        {
            var result = modelDB.proc_CargarTodosProductos();

            return result;
        }
        public ObjectResult<proc_CargarProductosExistBaja_Result> CargarProductosExistBaja()
        {
            var result = modelDB.proc_CargarProductosExistBaja();

            return result;
        }

        public ObjectResult<proc_CargarProductosExistBajaPorProveedor_Result> CargarProductosExistBajaPorProveedor(int proveedorID)
        {
            var result = modelDB.proc_CargarProductosExistBajaPorProveedor(proveedorID);

            return result;
        }

        public ObjectResult<proc_BuscarProductosPorID_Result> BuscarProductosPorID(int productoID)
        {
            var result = modelDB.proc_BuscarProductosPorID(productoID);

            return result;
        }

        public ObjectResult<proc_BuscarProductosPorProveedor_Result> BuscarProductosPorProveedor(int proveedorID)
        {
            var result = modelDB.proc_BuscarProductosPorProveedor(proveedorID);

            return result;
        }


        public ObjectResult<proc_BuscarProductosPorCodigoBarra_Result> BuscarProductosPorCodigoBarra(string codigoBarra)
        {
            var result = modelDB.proc_BuscarProductosPorCodigoBarra(codigoBarra);

            return result;
        }
        public ObjectResult<proc_BuscarCantidadProductosPorCodigoBarra_Result> BuscarCantidadProductosPorCodigoBarra(string codigoBarra)
        {
            var result = modelDB.proc_BuscarCantidadProductosPorCodigoBarra(codigoBarra);

            return result;
        }

        public bool EditarProducto(Producto producto)
        {
            modelDB.proc_ActualizarProducto(producto.ProductoID, producto.Descripcion, producto.Referencia, producto.CategoriaID, producto.Marca, producto.Existencia, producto.PrecioCompra, producto.PrecioVenta, producto.ProveedorID, producto.CodigoBarra, producto.Calidad, producto.ITBIS, producto.Descuento, producto.CantMin, producto.CantMax, resultado);
            return (bool)resultado.Value;
        }

        public bool ActualizarCantidadProducto(Producto producto)
        {
            modelDB.proc_ActualizarCantidadProducto(producto.CodigoBarra, producto.Existencia, resultado);

            return (bool)resultado.Value;
        }

        public bool BorrarProducto(int productoID)
        {
            modelDB.proc_BorrarProducto(productoID, resultado);
            return (bool)resultado.Value;
        }

        public ObjectResult<proc_Cargar10ProductosVendidosPFecha_Result> Cargar10ProductosVendidosPFecha(DateTime fInicial, DateTime fFinal)
        {
            var result = modelDB.proc_Cargar10ProductosVendidosPFecha(fInicial, fFinal);

            return result;
        }
    }
}
