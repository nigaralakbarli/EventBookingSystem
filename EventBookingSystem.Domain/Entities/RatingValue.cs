using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities
{
    public class RatingValue : BaseEntity
    {
        public int Value { get; set; }

        public virtual ICollection<EventEvaluation> EventEvaluations { get; set; }
    }
}
