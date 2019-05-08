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
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.DetalleFacturas = new HashSet<DetalleFactura>();
            this.DetalleNotaDeCreditoes = new HashSet<DetalleNotaDeCredito>();
        }
    
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }
        public int CategoriaID { get; set; }
        public string Marca { get; set; }
        public double Existencia { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int ProveedorID { get; set; }
        public string CodigoBarra { get; set; }
        public string Calidad { get; set; }
        public decimal Descuento { get; set; }
        public bool ITBIS { get; set; }
        public double CantMin { get; set; }
        public double CantMax { get; set; }
    
        public virtual CategoriasProd CategoriasProd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
        public virtual Proveedore Proveedore { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleNotaDeCredito> DetalleNotaDeCreditoes { get; set; }
    }
}
