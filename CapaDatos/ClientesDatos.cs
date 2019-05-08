using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClientesDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter clienteID = new ObjectParameter("ClienteID", typeof(int));

        public Tuple<bool, int> AgregarCliente(Cliente cliente)
        {
            modelDB.proc_InsertarCliente(clienteID,cliente.Nombre,cliente.CedulaORnc,cliente.Direccion,cliente.Contacto_1,cliente.Contacto_2,cliente.Descuento,resultado);

            return Tuple.Create((bool)resultado.Value, (int) clienteID.Value);
        }
        public ObjectResult<proc_CargarTodosClientes_Result> CargarTodosClientes()
        {
            var result = modelDB.proc_CargarTodosClientes();

            return result;
        }

        public ObjectResult<proc_BuscarClientesPorID_Result> BuscarClientesPorID(int clienteID)
        {
            var result = modelDB.proc_BuscarClientesPorID(clienteID);

            return result;
        }

        public bool EditarCliente(Cliente cliente)
        {
            modelDB.proc_ActualizarCliente(cliente.ClienteID, cliente.Nombre, cliente.CedulaORnc, cliente.Direccion, cliente.Contacto_1, cliente.Contacto_2, cliente.Descuento, resultado);
            return (bool) resultado.Value;
        }

        public bool BorrarCliente(int clienteID)
        {
            modelDB.proc_BorrarCliente(clienteID, resultado);
            return (bool)resultado.Value;
        }

        public bool VerificarCredito(int clienteID, decimal montoFactura)
        {
            modelDB.proc_VerificarLimite(resultado, clienteID, montoFactura);
            return (bool)resultado.Value;
        }
    }
}
