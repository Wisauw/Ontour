﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnTourDBEntities : DbContext
    {
        public OnTourDBEntities()
            : base("name=OnTourDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<COLEGIO> COLEGIO { get; set; }
        public DbSet<COMUNA> COMUNA { get; set; }
        public DbSet<DESTINO> DESTINO { get; set; }
        public DbSet<EJECUTIVO> EJECUTIVO { get; set; }
        public DbSet<PAQUETE_TURISTICO> PAQUETE_TURISTICO { get; set; }
        public DbSet<REGION> REGION { get; set; }
        public DbSet<SERVICIO> SERVICIO { get; set; }
    }
}
