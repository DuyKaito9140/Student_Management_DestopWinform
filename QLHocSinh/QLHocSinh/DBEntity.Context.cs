﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHocSinh
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBE_QLHS : DbContext
    {
        public DBE_QLHS()
            : base("name=DBE_QLHS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table_BangDiem> Table_BangDiem { get; set; }
        public virtual DbSet<Table_HocSinh> Table_HocSinh { get; set; }
        public virtual DbSet<Table_LopHoc> Table_LopHocs { get; set; }
    }
}
