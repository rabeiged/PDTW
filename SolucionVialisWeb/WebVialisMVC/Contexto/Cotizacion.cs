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
    
    public partial class Cotizacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cotizacion()
        {
            this.detalle_cotizacion = new HashSet<detalle_cotizacion>();
        }
    
        public string id_cotizacion { get; set; }
        public string id_proyecto { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string id_proveedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_cotizacion> detalle_cotizacion { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}
