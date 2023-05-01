using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities
{
    public class Venue : BaseEntity
    {
        public int Capacity { get; set; }
        public virtual ICollection<EventSeat> EventSeats { get; set; }
        public virtual ICollection<Event> Events{ get; set; }
    }
}
