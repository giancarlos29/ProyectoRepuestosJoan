using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class TiposPagosNegocio
    {
        TiposPagosDatos tiposPagosDatos = new TiposPagosDatos();

        public ObjectResult<proc_CargarTodosTiposPagos_Result> CargarTodosTiposPagos()
        {
            return tiposPagosDatos.CargarTodosTiposPagos();
        }

        public Tuple<bool, int> AgregarTipoPago(TiposPago tiposPago)
        {

            return tiposPagosDatos.AgregarTipoPago(tiposPago);
        }

        public bool EditarTipoPago(TiposPago tipoPago)
        {
            return tiposPagosDatos.EditarTipoPago(tipoPago);
        }

        public bool BorrarTipoPago(int tipoPagoID)
        {
            return tiposPagosDatos.BorrarTipoPago(tipoPagoID);
        }
    }
}
