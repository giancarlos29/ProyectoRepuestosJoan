//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    
    public partial class proc_CargarLineasCreditoVentasVencidas30PFecha_Result
    {
        public int LineaCreditoVentaID { get; set; }
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public int FacturaID { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<double> MontoFactura { get; set; }
        public Nullable<double> MontoPendiente { get; set; }
        public bool Estatus { get; set; }
    }
}
