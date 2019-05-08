using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetalleOrdenCompraDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter detalleOrdenCompraID = new ObjectParameter("DetalleOrdenCompraID", typeof(int));

        public Tuple<bool, int> InsertarDetalleOrdenCompra(DetalleOrdenesCompra detalleOrdenCompra)
        {
            modelDB.proc_InsertarDetalleOrdenCompra(detalleOrdenCompraID, detalleOrdenCompra.OrdenCompraID, detalleOrdenCompra.ProductoID, detalleOrdenCompra.CantidadOrdenada, detalleOrdenCompra.Precio, resultado);

            return Tuple.Create((bool)resultado.Value, (int)detalleOrdenCompraID.Value);
        }

        public ObjectResult<proc_CargarDetalleOrdenCompra_Result> CargarDetalleOrdenCompra(int ordenCompraID)
        {
            var result = modelDB.proc_CargarDetalleOrdenCompra(ordenCompraID);

            return result;
        }

        public bool ActualizarDetalleOrdenCompra(DetalleOrdenesCompra detalleOrdenCompra)
        {
            modelDB.proc_ActualizarDetalleOrdenCompra(detalleOrdenCompra.OrdenCompraID,detalleOrdenCompra.ProductoID,detalleOrdenCompra.CantidadOrdenada,detalleOrdenCompra.CantidadRecibida,detalleOrdenCompra.Precio, resultado);
            return (bool)resultado.Value;
        }

        public bool BorrarDetalleOrdenCompra(DetalleOrdenesCompra detalleOrdenCompra)
        {
            modelDB.proc_BorrarDetalleOrdenCompra(detalleOrdenCompra.OrdenCompraID, detalleOrdenCompra.ProductoID, resultado);
            return (bool)resultado.Value;
        }
    }
}
