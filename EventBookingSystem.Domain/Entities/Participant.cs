using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities
{
    public class Participant : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public int EventSeatId { get; set; }
        public int EventId { get; set; }
        public virtual EventSeat EventSeat { get; set; }
        public virtual User User { get; set; }
        public virtual Event Event { get; set; }

    }
}
