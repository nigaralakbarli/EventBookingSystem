using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities
{
    public class EventSeat : BaseEntity
    {
        public int Section { get; set; }
        public int Row { get; set; }
        public int SeatNumber { get; set; }
        public Venue? Venue { get; set; }
        public Participant? Participant { get; set; }    
    }
}
