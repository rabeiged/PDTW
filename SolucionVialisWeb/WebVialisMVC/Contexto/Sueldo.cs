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
    
    public partial class Sueldo
    {
        public decimal id_sueldo { get; set; }
        public Nullable<decimal> id_asignacion { get; set; }
        public Nullable<decimal> dias_trabajados { get; set; }
        public Nullable<decimal> valor_dia { get; set; }
        public Nullable<decimal> total { get; set; }
    
        public virtual trabajador_asignado trabajador_asignado { get; set; }
    }
}
