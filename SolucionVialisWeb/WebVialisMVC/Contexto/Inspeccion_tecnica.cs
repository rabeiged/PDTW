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
    
    public partial class Inspeccion_tecnica
    {
        public string id_inspeccion_tec { get; set; }
        public string id_tarea { get; set; }
        public string detalle_inspeccion_t { get; set; }
        public Nullable<decimal> nivel_avance { get; set; }
    
        public virtual Tarea Tarea { get; set; }
    }
}
