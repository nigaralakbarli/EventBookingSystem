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
            var categories = new List<Category>()
            {
                 new Category()
                {
                    Id = 1,
                    Name = "Career Development"
                },

                 new Category()
                {
                   Id = 2,
                   Name = "Social Activities"
                },
                new Category()
                {
                   Id = 3,
                   Name = "Study Abroad"
                },
                new Category()
                {
                   Id = 4,
                   Name = "Computer Science"
                },
                new Category()
                {
                   Id = 5,
                   Name = "Information Security"
                },
                new Category()
                {
                   Id = 6,
                   Name = "Artificial Intelligence"
                }
            };
            return categories;
        }
    }
}
