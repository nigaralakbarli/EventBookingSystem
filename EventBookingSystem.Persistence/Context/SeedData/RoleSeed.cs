using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Persistence.Context.SeedData
{
    public static partial class DataSeeder
    {
        public static List<Role> SeedRole()
        {
            List<Role> roles = new List<Role>()
            {
                 new Role()
                {
                     Id = 1,
                     Name = "Admin"
                },

                  new Role()
                {
                     Id = 2,
                     Name = "User"
                },
            };
            return roles;
        }
    }
    
}
