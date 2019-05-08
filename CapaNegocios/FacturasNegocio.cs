using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class FacturasNegocio
    {
        FacturasDatos facturasDatos = new FacturasDatos();

        public Tuple<bool, int> InsertarFactura(Factura factura)
        {

            return facturasDatos.InsertarFactura(factura);
        }

        public ObjectResult<proc_VerTipoUltimaFactura_Result> VerTipoUltimaFactura()
        {
            return facturasDatos.VerTipoUltimaFactura();
        }

        public ObjectResult<proc_CargarMontoFacturaNC_Result> CargarMontoFacturaNC(int facturaID)
        {
            return facturasDatos.CargarMontoFacturaNC(facturaID);
        }

        public ObjectResult<proc_CargarFacturasPendientes_Result> CargarFacturasPendientes(int clienteID)
        {
            return facturasDatos.CargarFacturasPendiente(clienteID);
        }
        
        public ObjectResult<proc_VerTipoPagoUltimaFactura_Result> VerTipoPagoUltimaFactura()
        {
            return facturasDatos.VerTipoPagoUltimaFactura();
        }

        public ObjectResult<proc_CargarProductosFactura_Result> CargarProductosFactura(int facturaID)
        {
            return facturasDatos.CargarProductosFactura(facturaID);
        }

        public bool ConfirmarFacturaYCliente(int facturaID, int clienteID)
        {
            return facturasDatos.ConfirmarFacturaYCliente(facturaID, clienteID);
        }

        public ObjectResult<proc_CargarTodasFacturas_Result> CargarTodasFacturas()
        {
            return facturasDatos.CargarTodasFacturas();
        }

        public ObjectResult<proc_CargarFacturaVentaCFinal_Result> CargarFacturaVentaCFinal()
        {
            return facturasDatos.CargarFacturaVentaCFinal();
        }

        public ObjectResult<proc_CargarFacturaVentaCFiscal_Result> CargarFacturaVentaCFiscal()
        {
            return facturasDatos.CargarFacturaVentaCFiscal();
        }
        public ObjectResult<proc_CargarFacturasPFecha_Result> CargarFacturasPFecha(DateTime fInicial, DateTime fFinal)
        {
            return facturasDatos.CargarFacturasPFecha(fInicial, fFinal);
        }
        public Tuple<decimal, decimal, decimal, decimal, decimal, decimal> CalcularGanancias()
        {
            return facturasDatos.CalcularGanancias();
        }
    }
}
