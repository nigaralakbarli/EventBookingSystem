using EventBookingSystem.Application.DTOs.EventSeat.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces;

public interface IEventSeatService
{
    List<EventSeatResponseDTO> GetSeatsByEventId(int eventId);
    bool BookSeat(int seatId);
    bool CancleBooking(int seatId);
}
