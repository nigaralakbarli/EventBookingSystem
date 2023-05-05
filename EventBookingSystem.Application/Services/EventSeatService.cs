using AutoMapper;
using EventBookingSystem.Application.DTOs.EventSeat.Response;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Domain.Repositories.EntityRepositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Services
{
    public class EventSeatService : IEventSeatService
    {
        private readonly IEventSeatRepository _eventSeatRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public EventSeatService(
            IEventSeatRepository eventSeatRepository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
        {
            _eventSeatRepository = eventSeatRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public List<EventSeatResponseDTO> GetSeatsByEventId(int eventId)
        {
            var seats = _eventSeatRepository.Find(s=> s.EventId == eventId).OrderBy(s=> s.Id);
            return _mapper.Map<List<EventSeatResponseDTO>>(seats);
        }

        public bool BookSeat(int seatId)
        {
            var seat = _eventSeatRepository.GetById(seatId);
            if(seat.IsAvailable != false)
            {
                seat.ParticipantId = GetCurrentUserId();
                seat.IsAvailable = false;
                _eventSeatRepository.Update(seat);
                return true;
            }
            return false;
        }

        public bool CancleBooking(int seatId) 
        {
            var seat = _eventSeatRepository.GetById(seatId);
            if (seat.IsAvailable != true)
            {
                seat.ParticipantId = null;
                seat.IsAvailable = false;
                _eventSeatRepository.Update(seat);
                return true;
            }
            return false;
        }

        public int GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return Convert.ToInt32(userId);
        }
    }
}
