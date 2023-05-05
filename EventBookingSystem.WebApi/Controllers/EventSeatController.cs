using EventBookingSystem.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers
{
    [Route("EventSeatController")]
    [ApiController]
    public class EventSeatController : ControllerBase
    {
        private readonly IEventSeatService _eventSeatService;

        public EventSeatController(IEventSeatService eventSeatService)
        {
            _eventSeatService = eventSeatService;
        }

        [Route("GetSeatsByVenue")]
        [HttpGet]
        public IActionResult GetSeats(int eventId) 
        {
            return Ok(_eventSeatService.GetSeatsByEventId(eventId));
        }

        [Route("BookSeat")]
        [HttpPut]
        public IActionResult BookSeat(int seatId)
        {
            if (_eventSeatService.BookSeat(seatId))
            {
                return Ok();
            }
            return BadRequest("Seat is not available");
        }

        [Route("CancleBooking")]
        [HttpPut]
        public IActionResult CancleBooking(int seatId)
        {
            if (_eventSeatService.CancleBooking(seatId))
            {
                return Ok();
            }
            return BadRequest("Seat is not booked");
        }

    }
}
