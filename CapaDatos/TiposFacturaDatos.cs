using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TiposFacturaDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter tipoFacturaID = new ObjectParameter("TipoFacturaID", typeof(int));

        public ObjectResult<proc_CargarTodosTiposFactura_Result> CargarTodosTiposFactura()
        {
            var result = modelDB.proc_CargarTodosTiposFactura();

            return result;
        }
        public Tuple<bool, int> AgregarTipoFactura(TiposFactura tiposFactura)
        {
            modelDB.proc_InsertarTiposFactura(tipoFacturaID, tiposFactura.TipoFactura, resultado);

            return Tuple.Create((bool)resultado.Value, (int)tipoFacturaID.Value);
        }

        public bool EditarTipoFactura(TiposFactura tiposFactura)
        {
            modelDB.proc_ActualizarTiposFacturas(tiposFactura.TipoFacturaID, tiposFactura.TipoFactura, resultado);
            return (bool)resultado.Value;
        }

        public bool BorrarTipoFactura(int tiposFacturaID)
        {
            modelDB.proc_BorrarTiposFacturas(tiposFacturaID, resultado);
            return (bool)resultado.Value;
        }
    }
}
