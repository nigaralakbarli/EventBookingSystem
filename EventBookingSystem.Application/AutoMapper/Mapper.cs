using AutoMapper;
using EventBookingSystem.Application.DTOs.Authentication.Request;
using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.Category.Response;
using EventBookingSystem.Application.DTOs.Event.Request;
using EventBookingSystem.Application.DTOs.Event.Response;
using EventBookingSystem.Application.DTOs.EventEvaluation.Request;
using EventBookingSystem.Application.DTOs.EventEvaluation.Response;
using EventBookingSystem.Application.DTOs.EventSeat.Response;
using EventBookingSystem.Application.DTOs.Participant.Request;
using EventBookingSystem.Application.DTOs.Participant.Response;
using EventBookingSystem.Application.DTOs.RatingValue.Request;
using EventBookingSystem.Application.DTOs.RatingValue.Response;
using EventBookingSystem.Application.DTOs.Role.Request;
using EventBookingSystem.Application.DTOs.Role.Response;
using EventBookingSystem.Application.DTOs.Speaker.Request;
using EventBookingSystem.Application.DTOs.Speaker.Response;
using EventBookingSystem.Application.DTOs.SpeakerEvent.Request;
using EventBookingSystem.Application.DTOs.SpeakerEvent.Response;
using EventBookingSystem.Application.DTOs.User.Request;
using EventBookingSystem.Application.DTOs.User.Response;
using EventBookingSystem.Application.DTOs.Venue.Request;
using EventBookingSystem.Application.DTOs.Venue.Response;
using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.AutoMapper;

public class Mapper : Profile
{
    public Mapper()
    {
        #region User
        CreateMap<RegistrationDTO, User>();
        CreateMap<User, UserResponseDTO>()
            .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Name));

        CreateMap<UserUpdateDTO, User>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember, context) => srcMember != null));
        #endregion

        #region Category
        CreateMap<CategoryRequestDTO, Category>();
        CreateMap<Category, CategoryResponseDTO>();
        #endregion

        #region Venue
        CreateMap<VenueRequestDTO, Venue>();
        CreateMap<Venue, VenueResponseDTO>();
        #endregion

        #region EventSeat
        CreateMap<EventSeat, EventSeatResponseDTO>()
            .ForMember(dest => dest.EventTitle, opt => opt.MapFrom(src => src.Event.Title));
        #endregion

        #region Event
        CreateMap<EventCreateDTO, Event>();
        CreateMap<EventUpdateDTO, Event>();
        CreateMap<Event, EventResponseDTO>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.VenueName, opt => opt.MapFrom(src => src.Venue.Name));
        ;
        #endregion

        #region EventEvaluation
        CreateMap<EventEvaluationRequestDTO, EventEvaluation>();
        CreateMap<EventEvaluation, EventEvaluationResponseDTO>()
            .ForMember(dest => dest.RatingValue, opt => opt.MapFrom(src => src.RatingValue.Value))
            .ForMember(dest => dest.EventTitle, opt => opt.MapFrom(src => src.Event.Title));
        #endregion

        #region Participant
        CreateMap<ParticipantRequestDTO, Participant>();
        CreateMap<Participant, ParticipantResponseDTO>()
            .ForMember(dest => dest.EventTitle, opt => opt.MapFrom(src => src.Event.Title));
        #endregion

        #region RatingValue
        CreateMap<RatingValueRequestDTO, RatingValue>();
        CreateMap<RatingValue, RatingValueResponseDTO>();
        #endregion

        #region Role
        CreateMap<RoleRequestDTO, Role>();
        CreateMap<Role, RoleResponseDTO>();
        #endregion

        #region Speaker
        CreateMap<SpeakerRequestDTO, Speaker>();
        CreateMap<Speaker, SpeakerResponseDTO>();
        #endregion

        #region SpeakerEvent
        CreateMap<SpeakerEventRequestDTO, SpeakerEvent>();
        CreateMap<SpeakerEvent, SpeakerEventResponseDTO>()
            .ForMember(dest => dest.SpeakerName, opt => opt.MapFrom(src => src.Speaker.FullName))
            .ForMember(dest => dest.EventTitle, opt => opt.MapFrom(src => src.Event.Title));
        #endregion
    }
}
