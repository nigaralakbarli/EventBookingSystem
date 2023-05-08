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
        public static List<Venue> SeedVenue()
        {
            var venues = new List<Venue>()
            {
                new Venue()
                {
                    Id = 1,
                    Name = "Akt zalı",
                    Capacity = 50, //400
                    RowCapacity = 10,
                }
                ,
                new Venue()
                {
                    Id = 2,
                    Name = "Otaq 201",
                    Capacity = 20, //400
                    RowCapacity = 5,
                }
            };
            return venues;
        }
    }
}
