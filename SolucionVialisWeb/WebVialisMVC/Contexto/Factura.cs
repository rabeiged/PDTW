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
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.Etapas = new HashSet<Etapa>();
        }
    
        public decimal id_factura { get; set; }
        public string detalle_factura { get; set; }
        public Nullable<decimal> costo { get; set; }
        public Nullable<System.DateTime> fecha_emision { get; set; }
        public string id_pago { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etapa> Etapas { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
