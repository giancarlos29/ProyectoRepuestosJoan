using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class OrdenesCompraDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter ordenCompraID = new ObjectParameter("OrdenCompraID", typeof(int));

        public Tuple<bool, int> InsertarOrdenCompra(OrdenesCompra ordenesCompra)
        {
            modelDB.proc_InsertarOrdenCompra(ordenCompraID, ordenesCompra.ProveedorID, ordenesCompra.FechaPedido, ordenesCompra.Estatus, resultado);

            return Tuple.Create((bool)resultado.Value, (int)ordenCompraID.Value);
        }

        public ObjectResult<proc_CargarTodasOrdenesCompra_Result> CargarTodasOrdenesCompra()
        {
            var result = modelDB.proc_CargarTodasOrdenesCompra();

            return result;
        }

        public void CerrarOrdenCompra (int ordenCompraID)
        {
            var resultado = modelDB.proc_CerrarOrdenCompra(ordenCompraID);            
        }

        public ObjectResult<proc_CargarOrdenesCompraPFecha_Result> CargarOrdenesCompraPFecha(DateTime fInicial, DateTime fFinal)
        {
            var result = modelDB.proc_CargarOrdenesCompraPFecha(fInicial, fFinal);

            return result;
        }
       
    }
}
