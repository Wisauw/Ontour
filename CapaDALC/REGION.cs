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
    
    public partial class REGION
    {
        public REGION()
        {
            this.CLIENTE = new HashSet<CLIENTE>();
            this.COMUNA = new HashSet<COMUNA>();
            this.COTIZACION = new HashSet<COTIZACION>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual ICollection<COMUNA> COMUNA { get; set; }
        public virtual ICollection<COTIZACION> COTIZACION { get; set; }
    }
}
