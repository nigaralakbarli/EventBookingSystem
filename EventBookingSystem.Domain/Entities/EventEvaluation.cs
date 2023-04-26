using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities
{
    public class EventEvaluation : BaseEntity
    {
        public string ExtraComment { get; set; }
        public int RatingValueId { get; set; }
        public int ParticipantId { get; set; }


        public RatingValue RatingValue { get; set; }
        public Participant Participant { get; set; }
        public Event Event { get; set; }

    }
}
