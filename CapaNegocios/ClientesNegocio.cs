using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class ClientesNegocio
    {
        ClientesDatos clientesDatos = new ClientesDatos();
        public Tuple<bool, int> AgregarCliente(Cliente cliente)
        {            

            return clientesDatos.AgregarCliente(cliente);
        }

        public ObjectResult<proc_CargarTodosClientes_Result> CargarTodosClientes()
        {
            return clientesDatos.CargarTodosClientes();
        }

        public ObjectResult<proc_BuscarClientesPorID_Result> BuscarClientesPorID(int clienteID)
        {
            return clientesDatos.BuscarClientesPorID(clienteID);
        }

        public bool EditarCliente(Cliente cliente)
        {
            return clientesDatos.EditarCliente(cliente);
        }

        public bool BorrarCliente(int clienteID)
        {
            return clientesDatos.BorrarCliente(clienteID);
        }

        public bool VerificarCredito(int clienteID, decimal montoFactura)
        {
            return clientesDatos.VerificarCredito(clienteID, montoFactura);
        }
    }
}
