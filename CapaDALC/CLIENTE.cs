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
    
    public partial class CLIENTE
    {
        public int Id { get; set; }
        public string Nombre_Completo { get; set; }
        public string Email { get; set; }
        public int Id_Colegio { get; set; }
        public int Id_Ejecutivo { get; set; }
        public int Id_Paquete_Turistico { get; set; }
        public int Id_Region { get; set; }
    
        public virtual COLEGIO COLEGIO { get; set; }
        public virtual EJECUTIVO EJECUTIVO { get; set; }
        public virtual PAQUETE_TURISTICO PAQUETE_TURISTICO { get; set; }
        public virtual REGION REGION { get; set; }
    }
}
