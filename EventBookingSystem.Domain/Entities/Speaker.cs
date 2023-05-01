using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities
{
    public class Speaker : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public virtual Event Event { get; set; }    
    }
}
