﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
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
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tb_AIRCRAFT> tb_AIRCRAFT { get; set; }
        public virtual DbSet<tb_AIRCRAFTSEATS> tb_AIRCRAFTSEATS { get; set; }
        public virtual DbSet<tb_AIRPORTS> tb_AIRPORTS { get; set; }
        public virtual DbSet<tb_BOOKINGS> tb_BOOKINGS { get; set; }
        public virtual DbSet<tb_CHECKINS> tb_CHECKINS { get; set; }
        public virtual DbSet<tb_CHUCVU> tb_CHUCVU { get; set; }
        public virtual DbSet<tb_FLIGHT> tb_FLIGHT { get; set; }
        public virtual DbSet<tb_FLIGHT_SCHEDULES> tb_FLIGHT_SCHEDULES { get; set; }
        public virtual DbSet<tb_FUNC> tb_FUNC { get; set; }
        public virtual DbSet<tb_Member> tb_Member { get; set; }
        public virtual DbSet<tb_NHANVIEN> tb_NHANVIEN { get; set; }
        public virtual DbSet<tb_PASSENGERS> tb_PASSENGERS { get; set; }
        public virtual DbSet<tb_PAYMENTS> tb_PAYMENTS { get; set; }
        public virtual DbSet<tb_PhanQuyen> tb_PhanQuyen { get; set; }
        public virtual DbSet<tb_SEATS> tb_SEATS { get; set; }
        public virtual DbSet<tb_TAIKHOANNHANVIEN> tb_TAIKHOANNHANVIEN { get; set; }
    }
}
