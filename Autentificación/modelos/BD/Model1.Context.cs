﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autentificación.modelos.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuario> UsuarioSet { get; set; }
        public virtual DbSet<Requerimientos> RequerimientosSet { get; set; }
        public virtual DbSet<Estado_Requerimiento> Estado_RequerimientoSet { get; set; }
        public virtual DbSet<tipo_de_requerimiento> tipo_de_requerimientoSet { get; set; }
        //public virtual DbSet<Rol> RolSet { get; set; }
    }
}
