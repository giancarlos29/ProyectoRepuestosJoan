using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class OrdenesCompraNegocio
    {   
            OrdenesCompraDatos ordenesCompraDatos = new OrdenesCompraDatos();

            public Tuple<bool, int> InsertarOrdenCompra(OrdenesCompra ordenCompra)
            {

                return ordenesCompraDatos.InsertarOrdenCompra(ordenCompra);
            }

        public ObjectResult<proc_CargarTodasOrdenesCompra_Result> CargarTodasOrdenesCompra()
        {
            return ordenesCompraDatos.CargarTodasOrdenesCompra();
        }

        public void CerrarOrdenCompra (int ordenCompraID)
        {
            ordenesCompraDatos.CerrarOrdenCompra(ordenCompraID);
        }

        public ObjectResult<proc_CargarOrdenesCompraPFecha_Result> CargarOrdenesCompraPFecha(DateTime fInicial, DateTime fFinal)
        {
            return ordenesCompraDatos.CargarOrdenesCompraPFecha(fInicial, fFinal);
        }
    }
}
