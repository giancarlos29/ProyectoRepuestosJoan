using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class NotasDeCreditoNegocio
    {
        NotasDeCreditoDatos notasDeCreditoDatos = new NotasDeCreditoDatos();

        public Tuple<bool, int> AgregarNotaDeCredito(NotasDeCredito notasDeCredito)
        {

            return notasDeCreditoDatos.AgregarNotaDeCredito(notasDeCredito);
        }

        public ObjectResult<proc_CargarTodasNotasDeCredito_Result> CargarTodasNotasDeCredito()
        {
            return notasDeCreditoDatos.CargarTodasNotasDeCredito();
        }

        public ObjectResult<proc_CargarNotasDeCreditoPFecha_Result> CargarNotasDeCreditoPFecha(DateTime fInicial, DateTime fFinal)
        {
            return notasDeCreditoDatos.CargarNotasDeCreditoPFecha(fInicial, fFinal);
        }


    }
}
