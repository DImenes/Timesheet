﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimesheetApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TimesheetEntities : DbContext
    {
        public TimesheetEntities()
            : base("name=TimesheetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TS_Client> TS_Client { get; set; }
        public DbSet<TS_HoursDay> TS_HoursDay { get; set; }
        public DbSet<TS_HoursKind> TS_HoursKind { get; set; }
        public DbSet<TS_Project> TS_Project { get; set; }
        public DbSet<TS_User> TS_User { get; set; }
        public DbSet<TS_UserProject> TS_UserProject { get; set; }
        public DbSet<TS_Holiday> TS_Holiday { get; set; }
    }
}
