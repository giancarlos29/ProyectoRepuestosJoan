using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class FacturasDatos
    {
        SistemaFacturacionRepuestoJoanEntities modelDB = new SistemaFacturacionRepuestoJoanEntities();
        ObjectParameter resultado = new ObjectParameter("resultado", typeof(bool));
        ObjectParameter facturaID = new ObjectParameter("FacturaID", typeof(int));
        ObjectParameter gananciaFContDia = new ObjectParameter("GananciaFContDia", typeof(decimal));
        ObjectParameter gananciaFContSemana = new ObjectParameter("GananciaFContSemana", typeof(decimal));
        ObjectParameter gananciaFContMes = new ObjectParameter("GananciaFContMes", typeof(decimal));
        ObjectParameter gananciaFCredDia = new ObjectParameter("GananciaFCredDia", typeof(decimal));
        ObjectParameter gananciaFCredSemana = new ObjectParameter("GananciaFCredSemana", typeof(decimal));
        ObjectParameter gananciaFCredtMes = new ObjectParameter("GananciaFCredMes", typeof(decimal));

        public Tuple<bool, int> InsertarFactura(Factura factura)
        {
            modelDB.proc_InsertarFactura(facturaID, factura.ClienteID, factura.Fecha, factura.TipoPagoID, factura.TipoFacturaID,factura.NCF, factura.FechaVencimiento, factura.UserID, factura.RNC, factura.Entidad, resultado);

            return Tuple.Create((bool)resultado.Value, (int)facturaID.Value);
        }

        public ObjectResult<proc_VerTipoUltimaFactura_Result> VerTipoUltimaFactura()
        {
            var result = modelDB.proc_VerTipoUltimaFactura();
            return result;
        }

        public ObjectResult<proc_CargarMontoFacturaNC_Result> CargarMontoFacturaNC(int facturaID)
        {
            var result = modelDB.proc_CargarMontoFacturaNC(facturaID);
            return result;
        }

        public ObjectResult<proc_CargarFacturasPendientes_Result> CargarFacturasPendiente(int clienteID)
        {
            var result = modelDB.proc_CargarFacturasPendientes(clienteID);
            return result;
        }

        public ObjectResult<proc_VerTipoPagoUltimaFactura_Result> VerTipoPagoUltimaFactura()
        {
            var result = modelDB.proc_VerTipoPagoUltimaFactura();
            return result;
        }

        public ObjectResult<proc_CargarProductosFactura_Result> CargarProductosFactura(int facturaID)
        {
            var result = modelDB.proc_CargarProductosFactura(facturaID);
            return result;
        }

        public bool ConfirmarFacturaYCliente(int facturaID, int clienteID)
        {
            modelDB.proc_ConfirmarFacturaYCliente(facturaID,clienteID, resultado);
            return (bool) resultado.Value;
        }

        public ObjectResult<proc_CargarTodasFacturas_Result> CargarTodasFacturas()
        {
            var result = modelDB.proc_CargarTodasFacturas();
            return result;
        }

        public ObjectResult<proc_CargarFacturaVentaCFinal_Result> CargarFacturaVentaCFinal()
        {
            var result = modelDB.proc_CargarFacturaVentaCFinal();
            return result;
        }

        public ObjectResult<proc_CargarFacturaVentaCFiscal_Result> CargarFacturaVentaCFiscal()
        {
            var result = modelDB.proc_CargarFacturaVentaCFiscal();
            return result;
        }

        public ObjectResult<proc_CargarFacturasPFecha_Result> CargarFacturasPFecha(DateTime fInicial, DateTime fFinal)
        {
            var result = modelDB.proc_CargarFacturasPFecha(fInicial, fFinal);
            return result;
        }

        public Tuple<decimal,decimal,decimal,decimal,decimal,decimal>CalcularGanancias()
        {
            modelDB.proc_CalcularGanancias(gananciaFContDia,gananciaFContSemana,gananciaFContMes,gananciaFCredDia,gananciaFCredSemana,gananciaFCredtMes);

            return Tuple.Create((decimal)gananciaFContDia.Value, (decimal)gananciaFContSemana.Value, (decimal)gananciaFContMes.Value, (decimal)gananciaFCredDia.Value, (decimal)gananciaFCredSemana.Value, (decimal)gananciaFCredtMes.Value);
        }
    }
}
