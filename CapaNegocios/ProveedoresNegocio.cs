using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocios
{
    public class ProveedoresNegocio
    {
        ProveedoresDatos proveedoresDatos = new ProveedoresDatos();
        public Tuple<bool, int> AgregarProveedor(Proveedore proveedor)
        {

            return proveedoresDatos.AgregarProveedor(proveedor);
        }

        public ObjectResult<proc_CargarTodosProveedores_Result> CargarTodosProveedores()
        {
            return proveedoresDatos.CargarTodosProveedores();
        }

        public ObjectResult<proc_BuscarProveedoresPorID_Result> BuscarProveedoresPorID(int proveedorID)
        {
            return proveedoresDatos.BuscarProveedoresPorID(proveedorID);
        }

        public bool EditarProveedor(Proveedore proveedor)
        {
            return proveedoresDatos.EditarProveedor(proveedor);
        }

        public bool BorrarProveedor(int proveedorID)
        {
            return proveedoresDatos.BorrarProveedor(proveedorID);
        }
    }
}
