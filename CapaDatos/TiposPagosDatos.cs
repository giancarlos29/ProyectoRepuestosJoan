using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TiposPagosDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter tipoPagoID = new ObjectParameter("TipoPagoID", typeof(int));

        public ObjectResult<proc_CargarTodosTiposPagos_Result> CargarTodosTiposPagos()
        {
            var result = modelDB.proc_CargarTodosTiposPagos();
        
            return result;
        }
        public Tuple<bool, int> AgregarTipoPago(TiposPago tiposPago)
        {
            modelDB.proc_InsertarTipoPago(tipoPagoID, tiposPago.TipoDePago, resultado);

            return Tuple.Create((bool)resultado.Value, (int)tipoPagoID.Value);
        }

        public bool EditarTipoPago(TiposPago tiposPago)
        {
            modelDB.proc_ActualizarTiposPagos(tiposPago.TipoPagoID, tiposPago.TipoDePago, resultado);
            return (bool)resultado.Value;
        }

        public bool BorrarTipoPago(int tipoPagosID)
        {
            modelDB.proc_BorrarTiposPagos(tipoPagosID, resultado);
            return (bool)resultado.Value;
        }
    }
}
