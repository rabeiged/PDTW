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
    
    public partial class Stock_RRFF_EMPRESA
    {
        public string id_material { get; set; }
        public string rol { get; set; }
        public string marca { get; set; }
        public string nombre_producto { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public string id_boleta { get; set; }
        public Nullable<decimal> id_categoria { get; set; }
    
        public virtual Boleta Boleta { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
