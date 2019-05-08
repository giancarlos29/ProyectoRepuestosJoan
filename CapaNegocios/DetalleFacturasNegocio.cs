using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DetalleFacturasNegocio
    {
        DetalleFacturaDatos detalleFacturasDatos = new DetalleFacturaDatos();

        public Tuple<bool, int> InsertarDetalleFactura(DetalleFactura detalleFactura)
        {

            return detalleFacturasDatos.InsertarDetalleFactura(detalleFactura);
        }

        public ObjectResult<proc_CargarDetalleFacturaVenta_Result> CargarDetalleFacturaVenta(int facturaID)
        {
            return detalleFacturasDatos.CargarDetalleFacturaVenta(facturaID);
        }
    }
}
