﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SupenEntities : DbContext
    {
        public SupenEntities()
            : base("name=SupenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Blogg> Blogg { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Teams> Teams { get; set; }
    }
}
