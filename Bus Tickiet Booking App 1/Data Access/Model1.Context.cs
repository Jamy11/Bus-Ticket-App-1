﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bus_Tickiet_Booking_App_1.Data_Access
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BusTicketDb : DbContext
    {
        public BusTicketDb()
            : base("name=BusTicketDb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AddBus> AddBus { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<seat> seat { get; set; }
        public DbSet<User> User { get; set; }
    }
}
