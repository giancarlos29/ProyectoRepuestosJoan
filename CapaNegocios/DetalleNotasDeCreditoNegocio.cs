using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class DetalleNotasDeCreditoNegocio
    {
        DetalleNotasDeCreditoDatos detalleNotasDeCreditoDatos = new DetalleNotasDeCreditoDatos();

        public Tuple<bool, int> AgregarDetalleNotaDeCredito(DetalleNotaDeCredito detalleNotaDeCredito)
        {

            return detalleNotasDeCreditoDatos.AgregarDetalleNotaDeCredito(detalleNotaDeCredito);
        }

        public ObjectResult<proc_CargarDetalleNotaDeCredito_Result> CargarDetalleNotaDeCredito(int notaDeCreditoID)
        {
            return detalleNotasDeCreditoDatos.CargarDetalleNotaDeCredito(notaDeCreditoID);
        }
    }
}
