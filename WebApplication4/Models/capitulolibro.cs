//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class capitulolibro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public capitulolibro()
        {
            this.capitulo_grupo = new HashSet<capitulo_grupo>();
        }
    
        public int idCapituloLibro { get; set; }
        public string Nombre { get; set; }
        public string Autores { get; set; }
        public Nullable<int> Año { get; set; }
        public string ISBN { get; set; }
        public string Participantes { get; set; }
        public string Libro { get; set; }
        public Nullable<int> Usuario { get; set; }
        public Nullable<int> Archivo { get; set; }
    
        public virtual archivo archivo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<capitulo_grupo> capitulo_grupo { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}
