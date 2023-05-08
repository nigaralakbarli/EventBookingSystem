using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Domain.Entities;

public class Venue : BaseEntity
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public int RowCapacity { get; set; }
    public virtual ICollection<Event> Events{ get; set; }
}
