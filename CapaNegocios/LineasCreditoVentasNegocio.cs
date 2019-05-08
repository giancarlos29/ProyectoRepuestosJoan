using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class LineasCreditoVentasNegocio
    {
        LineasCreditoVentasDatos lineasCreditoVentasDatos = new LineasCreditoVentasDatos();

        public Tuple<bool, int> InsertarLineaCreditoVenta(LineasCreditoVenta lineaCreditoVenta)
        {

            return lineasCreditoVentasDatos.InsertarLineaCreditoVenta(lineaCreditoVenta);
        }

        public ObjectResult<proc_CargarTodasLineasCreditoVentas_Result> CargarTodasLineasCreditoVentas()
        {
           return lineasCreditoVentasDatos.CargarTodasLineasCreditoVentas();
        }
        public ObjectResult<proc_CargarTodasLineasCreditoVentasCompletadas_Result> CargarTodasLineasCreditoVentasCompletadas()
        {
            return lineasCreditoVentasDatos.CargarTodasLineasCreditoVentasCompletadas();
        }
        public ObjectResult<proc_CargarTodasLineasCreditoVentasPendientes_Result> CargarTodasLineasCreditoVentasPendientes()
        {
            return lineasCreditoVentasDatos.CargarTodasLineasCreditoVentasPendientes();
        }
        public ObjectResult<proc_CargarTodasLineasCreditoVentasVencidas30_Result> CargarTodasLineasCreditoVentasVencidas30()
        {
            return lineasCreditoVentasDatos.CargarTodasLineasCreditoVentasVencidas30();
        }
        public ObjectResult<proc_CargarTodasLineasCreditoVentasVencidas60_Result> CargarTodasLineasCreditoVentasVencidas60()
        {
            return lineasCreditoVentasDatos.CargarTodasLineasCreditoVentasVencidas60();
        }
        public bool ActualizarLineaCreditoVenta(LineasCreditoVenta lineaCreditoVenta)
        {
            return lineasCreditoVentasDatos.ActualizarLineaCreditoVenta(lineaCreditoVenta);
        }

        public int BuscarLineaDeCreditoVentaIDFactura(int facturaID)
        {
            return lineasCreditoVentasDatos.BuscarLineaDeCreditoVentaIDFactura(facturaID);
        }

        public ObjectResult<proc_CargarLineasCreditoVentasPendientesPFecha_Result> CargarLineasCreditoVentasPendientesPFecha(DateTime fInicial, DateTime fFinal)
        {
            return lineasCreditoVentasDatos.CargarLineasCreditoVentasPendientesPFecha(fInicial, fFinal);
        }
        public ObjectResult<proc_CargarLineasCreditoVentasCompletadasPFecha_Result> CargarLineasCreditoVentasCompletadasPFecha(DateTime fInicial, DateTime fFinal)
        {
            return lineasCreditoVentasDatos.CargarLineasCreditoVentasCompletadasPFecha(fInicial, fFinal);
        }
        public ObjectResult<proc_CargarLineasCreditoVentasVencidas30PFecha_Result> CargarLineasCreditoVentasVencidas30PFecha(DateTime fInicial, DateTime fFinal)
        {
            return lineasCreditoVentasDatos.CargarLineasCreditoVentasVencidas30PFecha(fInicial, fFinal);

        }
    }
}
