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
    
    public partial class concentrado_grupos
    {
        public int idConcentrado_Grupos { get; set; }
        public Nullable<int> Concentrado { get; set; }
        public Nullable<int> Grupo { get; set; }
    
        public virtual concentrado concentrado1 { get; set; }
        public virtual grupoacademico grupoacademico { get; set; }
    }
}