using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class TiposFacturaNegocio
    {
        TiposFacturaDatos tiposFacturaDatos = new TiposFacturaDatos();

        public ObjectResult<proc_CargarTodosTiposFactura_Result> CargarTodosTiposFactura()
        {
            return tiposFacturaDatos.CargarTodosTiposFactura();
        }

        public Tuple<bool, int> AgregarTiposFactura(TiposFactura tiposFactura)
        {

            return tiposFacturaDatos.AgregarTipoFactura(tiposFactura);
        }

        public bool EditarTipoFactura(TiposFactura tiposFactura)
        {
            return tiposFacturaDatos.EditarTipoFactura(tiposFactura);
        }

        public bool BorrarTipoFactura(int tipoFacturaID)
        {
            return tiposFacturaDatos.BorrarTipoFactura(tipoFacturaID);
        }

    }
}
