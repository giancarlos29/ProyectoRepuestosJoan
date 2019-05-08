using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CobrosVentaCreditoNegocio
    {
        CobrosVentaCreditoDatos cobrosVentaCreditoDatos = new CobrosVentaCreditoDatos();

        public Tuple<bool, int> InsertarCobroVentaCredito(CobrosVentasCredito cobrosVentasCredito)
        {

            return cobrosVentaCreditoDatos.InsertarCobroVentaCredito(cobrosVentasCredito);
        }

        public ObjectResult<proc_CargarCobrosVentaCredito_Result> CargarCobrosVentaCredito(int lineaCreditoVentaID)
        {
            return cobrosVentaCreditoDatos.CargarCobrosVentaCredito(lineaCreditoVentaID);
        }

        public bool ComprobarPagoLineaCreditoVenta (int lineaCreditoVentaID, decimal pagoLineaCreditoVenta)
        {
            return cobrosVentaCreditoDatos.ComprobarPagoLineaCreditoVenta(lineaCreditoVentaID, pagoLineaCreditoVenta);
        }

        public ObjectResult<proc_ComprobantePagoLineaCreditoVenta_Result> ComprobantePagoLineaCreditoVenta()
        {
            return cobrosVentaCreditoDatos.ComprobantePagoLineaCreditoVenta();
        }

        public ObjectResult<proc_CargarCobrosVentaCreditoPFecha_Result> CargarCobrosVentaCreditoPFecha(DateTime fInicial, DateTime fFinal)
        {
            return cobrosVentaCreditoDatos.CargarCobrosVentaCreditoPFecha(fInicial, fFinal);
        }
    }
}
