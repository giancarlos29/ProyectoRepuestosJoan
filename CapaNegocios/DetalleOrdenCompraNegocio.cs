using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Entity.Core.Objects;

namespace CapaNegocios
{
    public class DetalleOrdenCompraNegocio
    {
        DetalleOrdenCompraDatos detalleOrdenCompraDatos = new DetalleOrdenCompraDatos();

        public Tuple<bool, int> InsertarDetalleOrdenCompra(DetalleOrdenesCompra detalleOrdenCompra)
        {

            return detalleOrdenCompraDatos.InsertarDetalleOrdenCompra(detalleOrdenCompra);
        }

        public ObjectResult<proc_CargarDetalleOrdenCompra_Result> CargarDetalleOrdenCompra(int ordenCompraID)
        {
            return detalleOrdenCompraDatos.CargarDetalleOrdenCompra(ordenCompraID);
        }

        public bool ActualizarDetalleOrdenCompra(DetalleOrdenesCompra detalleOrdenCompra)
        {
            return detalleOrdenCompraDatos.ActualizarDetalleOrdenCompra(detalleOrdenCompra);
        }

        public bool BorrarDetalleOrdenCompra(DetalleOrdenesCompra detalleOrdenCompra)
        {
            return detalleOrdenCompraDatos.BorrarDetalleOrdenCompra(detalleOrdenCompra);
        }
    }
}
