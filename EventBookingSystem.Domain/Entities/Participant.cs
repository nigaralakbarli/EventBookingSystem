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
        public EventSeat EventSeat { get; set; }
        public User User { get; set; }
        public Event Event { get; set; }
        public EventEvaluation EventEvaluation { get; set; }

    }
}
