﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Tarea1Entities : DbContext
    {
        public Tarea1Entities()
            : base("name=Tarea1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Evento> tbl_Evento { get; set; }
        public virtual DbSet<tbl_PadronAsociado> tbl_PadronAsociado { get; set; }
        public virtual DbSet<tbl_Usuario> tbl_Usuario { get; set; }
    }
}
