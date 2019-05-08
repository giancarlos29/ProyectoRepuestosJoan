using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace CapaDatos
{
    public class FacturaOrdenCompraDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter facturaCompraID = new ObjectParameter("FacturaCompraID", typeof(int));

        public Tuple<bool, int> InsertarFacturaOrdenCompra( FacturasCompra facturaCompra)
        {
            modelDB.proc_InsertarFacturaCompra(facturaCompraID, facturaCompra.ProveedorID, facturaCompra.OrdenCompraID, facturaCompra.NCF, facturaCompra.FechaVencimientoSecuencia, facturaCompra.FechaFactura, facturaCompra.TipoDePagoID, facturaCompra.SubTotal, facturaCompra.ITBIS,resultado);

            return Tuple.Create((bool)resultado.Value, (int)facturaCompraID.Value);
        }
    }
}
