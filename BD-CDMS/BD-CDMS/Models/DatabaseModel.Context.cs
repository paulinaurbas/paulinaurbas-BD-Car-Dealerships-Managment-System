﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_CDMS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DealershipSalon> DealershipSalon { get; set; }
        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
    }
}
