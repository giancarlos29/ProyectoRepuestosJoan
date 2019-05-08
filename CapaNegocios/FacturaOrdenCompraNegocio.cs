using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using CapaDatos;

namespace CapaNegocios
{
    public class FacturaOrdenCompraNegocio
    {
        FacturaOrdenCompraDatos facturasOrdenCompraDatos = new FacturaOrdenCompraDatos();

        public Tuple<bool, int> InsertarFacturaOrdenCompra(FacturasCompra facturaOrdenCompra)
        {

            return facturasOrdenCompraDatos.InsertarFacturaOrdenCompra(facturaOrdenCompra);
        }
    }
}
