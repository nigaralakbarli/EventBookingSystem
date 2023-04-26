using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int VenueId { get; set; }
        public int CategoryId { get; set; }


        //Agenda


        #region Navigation Properties

        public Venue Venue { get; set; }
        public Category Category { get; set; }
        public ICollection<Participant> Participants { get; set; }
        public ICollection<EventEvaluation> EventEvaluations { get; set; }
        public ICollection<Speaker> Speakers { get; set; }

        #endregion


    }
}
