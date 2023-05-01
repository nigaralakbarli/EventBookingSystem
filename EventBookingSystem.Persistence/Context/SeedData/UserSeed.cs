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
        public static List<User> SeedUser()
        {
            List<User> users = new List<User>()
            {
                 new User()
                {
                    Id = 1,
                    FirstName = "Nigar",
                    LastName = "Alakbarli",
                    Email = "1",
                    Password = "1",
                    RoleId = 1
                },

                  new User()
                {
                    Id = 2,
                    FirstName = "Ali",
                    LastName = "Ahmed",
                    Email = "ahmed",
                    Password = "12",
                    RoleId = 2
                }
            };
            return users;
        }
    }
}
