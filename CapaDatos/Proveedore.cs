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
    
    public partial class Proveedore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedore()
        {
            this.Productos = new HashSet<Producto>();
            this.FacturasCompras = new HashSet<FacturasCompra>();
        }
    
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string CedulaORnc { get; set; }
        public string Direccion { get; set; }
        public string Contacto_1 { get; set; }
        public string Contacto_2 { get; set; }
        public string DatoAdicional { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturasCompra> FacturasCompras { get; set; }
    }
}
