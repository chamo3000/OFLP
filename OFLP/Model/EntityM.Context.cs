﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OFLP.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MIGANEntities1 : DbContext
    {
        public MIGANEntities1()
            : base("name=MIGANEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLASE> CLASE { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<GASTO> GASTO { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<SEXO> SEXO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
    }
}
