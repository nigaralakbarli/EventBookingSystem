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
        public int Eventİd { get; set; }


        public virtual RatingValue RatingValue { get; set; }
        public virtual Event Event { get; set; }
    }
}
