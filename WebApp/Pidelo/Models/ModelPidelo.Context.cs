﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pidelo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pidelodbEntities : DbContext
    {
        public pidelodbEntities()
            : base("name=pidelodbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCliente> tblCliente { get; set; }
        public virtual DbSet<tblTipoDocumento> tblTipoDocumento { get; set; }
        public virtual DbSet<tblUsuario> tblUsuario { get; set; }
        public virtual DbSet<tblZona> tblZona { get; set; }
    }
}
