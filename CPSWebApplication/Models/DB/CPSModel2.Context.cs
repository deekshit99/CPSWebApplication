﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPSWebApplication.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CPSCreationEntities : DbContext
    {
        public CPSCreationEntities()
            : base("name=CPSCreationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Catalog16_17> Catalog16_17 { get; set; }
        public virtual DbSet<CSCI_Courses> CSCI_Courses { get; set; }
        public virtual DbSet<DMST_Courses> DMST_Courses { get; set; }
        public virtual DbSet<SENG_Courses> SENG_Courses { get; set; }
        public virtual DbSet<StudentDetail> StudentDetails { get; set; }
        public virtual DbSet<SWEN_Courses> SWEN_Courses { get; set; }
    }
}
