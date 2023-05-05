using EventBookingSystem.Application.DTOs.Event.Request;
using EventBookingSystem.Application.DTOs.Event.Response;
using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces
{
    public interface IEventService
    {
        List<EventResponseDTO> GetAll();
        EventResponseDTO GetById(int id);
        void CreateEvent(EventCreateDTO eventCreate);
        bool UpdateEvent(EventUpdateDTO eventUpdate);
        bool DeleteEvent(int eventId);
    }
}
