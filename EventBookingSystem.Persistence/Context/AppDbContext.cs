using Azure.Core;
using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Persistence.Context.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=EventBookingSystem;Username=postgres;Password=nigaR123");
            


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seeder();
        }
        public DbSet<User> Users { get; set; }

    }
}
