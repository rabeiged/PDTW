//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebVialisMVC.Contexto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.Trabajador_empresa = new HashSet<Trabajador_empresa>();
        }
    
        public string Persona_run { get; set; }
        public string Persona_nombre { get; set; }
        public string Persona_apellido_paterno { get; set; }
        public string Persona_apellido_materno { get; set; }
        public string Persona_sexo { get; set; }
        public Nullable<System.DateTime> Persona_fecha_nacimiento { get; set; }
        public string Persona_direccion { get; set; }
        public Nullable<decimal> Persona_id_comuna { get; set; }
        public string Persona_estado_civil { get; set; }
    
        public virtual Comuna Comuna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trabajador_empresa> Trabajador_empresa { get; set; }
    }
}