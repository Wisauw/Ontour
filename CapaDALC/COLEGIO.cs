//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class COLEGIO
    {
        public COLEGIO()
        {
            this.CLIENTE = new HashSet<CLIENTE>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Nombre_Rector { get; set; }
        public string Telefono_Rector { get; set; }
        public string Nombre_Representante { get; set; }
        public string Telefono_Representante { get; set; }
        public int Id_curso { get; set; }
        public Nullable<int> Participantes { get; set; }
        public string Email_Rector { get; set; }
        public string Email_Representante { get; set; }
        public int Id_Sigla { get; set; }
    
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual CURSO CURSO { get; set; }
        public virtual SIGLA SIGLA { get; set; }
    }
}
