using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace CapaDatos
{
   public class NotasDeCreditoDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter notaDeCreditoID = new ObjectParameter("NotaDeCreditoID", typeof(int));

        public Tuple<bool, int> AgregarNotaDeCredito(NotasDeCredito notasDeCredito)
        {
            modelDB.proc_InsertarNotaDeCredito(notaDeCreditoID, notasDeCredito.FacturaID, notasDeCredito.FacturaAplicarID, notasDeCredito.Fecha, notasDeCredito.UserID, notasDeCredito.NCF, notasDeCredito.FechaVencimiento, notasDeCredito.ValorAplicado,resultado);

            return Tuple.Create((bool)resultado.Value, (int)notaDeCreditoID.Value);
        }

        public ObjectResult<proc_CargarTodasNotasDeCredito_Result> CargarTodasNotasDeCredito()
        {
            var result = modelDB.proc_CargarTodasNotasDeCredito();

            return result;
        }

        public ObjectResult<proc_CargarNotasDeCreditoPFecha_Result> CargarNotasDeCreditoPFecha(DateTime fInicial, DateTime fFinal)
        {
            var result = modelDB.proc_CargarNotasDeCreditoPFecha(fInicial, fFinal);

            return result;
        }

    }
}
