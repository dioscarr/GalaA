﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GalaDBEntities : DbContext
    {
        public GalaDBEntities()
            : base("name=GalaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aboutus> Aboutus { get; set; }
        public virtual DbSet<CMFRelation> CMFRelation { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<FCRelation> FCRelation { get; set; }
        public virtual DbSet<Firm> Firm { get; set; }
        public virtual DbSet<Gazette> Gazette { get; set; }
        public virtual DbSet<GazetteVolumes> GazetteVolumes { get; set; }
        public virtual DbSet<GMLink> GMLink { get; set; }
        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<Publication> Publication { get; set; }
        public virtual DbSet<publicationBooks> publicationBooks { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<PassRelation> PassRelation { get; set; }
    }
}
