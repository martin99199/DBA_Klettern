﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KletterDatenbank_MuellerPachler
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EF_KletterRoutenContainer : DbContext
    {
        public EF_KletterRoutenContainer()
            : base("name=EF_KletterRoutenContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Person> PersonSet { get; set; }
        public virtual DbSet<ZOT_Wunschliste> ZOT_WunschlisteSet { get; set; }
        public virtual DbSet<ZOT_Durchstiegsliste> ZOT_DurchstiegslisteSet { get; set; }
        public virtual DbSet<Route> RouteSet { get; set; }
        public virtual DbSet<Sektor> SektorSet { get; set; }
        public virtual DbSet<Gebiet> GebietSet { get; set; }
    }
}
