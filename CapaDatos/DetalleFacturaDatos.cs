using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetalleFacturaDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter detalleFacturaID = new ObjectParameter("DetalleFacturaID", typeof(int));

        public Tuple<bool, int> InsertarDetalleFactura(DetalleFactura detalleFactura)
        {
            modelDB.proc_InsertarDetalleFactura(detalleFacturaID, detalleFactura.FacturaID, detalleFactura.ProductoID, detalleFactura.CantVen, detalleFactura.Precio, detalleFactura.ITBIS, detalleFactura.Descuento, resultado);

            return Tuple.Create((bool)resultado.Value, (int)detalleFacturaID.Value);
        }

        public ObjectResult<proc_CargarDetalleFacturaVenta_Result> CargarDetalleFacturaVenta(int facturaID)
        {
            var result = modelDB.proc_CargarDetalleFacturaVenta(facturaID);
            return result;
        }
    }
}
