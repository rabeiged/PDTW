//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebVialisMVC.Contexto
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_boleta
    {
        public decimal id_detalle_boleta { get; set; }
        public decimal cantidad { get; set; }
        public Nullable<decimal> precio { get; set; }
        public string id_boleta { get; set; }
        public string id_producto { get; set; }
    
        public virtual boleta boleta { get; set; }
        public virtual producto producto { get; set; }
    }
}
