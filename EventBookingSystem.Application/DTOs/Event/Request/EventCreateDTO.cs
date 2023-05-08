using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.DTOs.Event.Request;

public class EventCreateDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int VenueId { get; set; }
    public int CategoryId { get; set; }
}
