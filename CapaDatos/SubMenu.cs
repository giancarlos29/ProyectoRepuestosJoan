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
    
    public partial class SubMenu
    {
        public int SubMenuID { get; set; }
        public string SubMenu1 { get; set; }
        public int MenuID { get; set; }
        public int Active { get; set; }
    
        public virtual Menu Menu { get; set; }
    }
}