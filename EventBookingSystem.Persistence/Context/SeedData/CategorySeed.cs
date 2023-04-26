using EventBookingSystem.Domain.Entities;
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
        public static List<Category> SeedCategory()
        {
            List<Category> categories = new List<Category>()
            {
                 new Category()
                {
                    Id = 1,
                    Name = "Test"
                },

                  new Category()
                {
                   Id = 2,
                   Name = "Test1"
                },
            };
            return categories;
        }
    }
}
