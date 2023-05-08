using EventBookingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Persistence.Context.SeedData
{
    public static partial class DataSeeder
    {
        public static void Seeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(SeedCategory());
            modelBuilder.Entity<Role>().HasData(SeedRole());
            modelBuilder.Entity<User>().HasData(SeedUser());
            modelBuilder.Entity<Venue>().HasData(SeedVenue());
            
        }
    }
}
