using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Persistence.Context
{
    public class VejBookingOnionDbContext : DbContext, IVejBookingOnionDbContext
    {

        // Constructor
        public VejBookingOnionDbContext(DbContextOptions<VejBookingOnionDbContext> options) : base(options)
        {

        }


        // Db Sets
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }



        // On Model Creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
