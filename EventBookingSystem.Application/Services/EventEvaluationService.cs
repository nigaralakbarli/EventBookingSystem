using AutoMapper;
using EventBookingSystem.Application.DTOs.EventEvaluation.Request;
using EventBookingSystem.Application.DTOs.EventEvaluation.Response;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Domain.Repositories.EntityRepositories;
using EventBookingSystem.Persistence.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Services;

public class EventEvaluationService : IEventEvaluationService
{
    private readonly IEventEvaluationRepository _eventEvaluationRepository;
    private readonly IMapper _mapper;

    public EventEvaluationService(
        IEventEvaluationRepository eventEvaluationRepository,
        IMapper mapper)
    {
        _eventEvaluationRepository = eventEvaluationRepository;
        _mapper = mapper;
    }

    public List<EventEvaluationResponseDTO> GetEventEvaluations()
    {
        return _mapper.Map<List<EventEvaluationResponseDTO>>(_eventEvaluationRepository.GetAll());
    }

    public List<EventEvaluationResponseDTO> GetByRatingValue(int ratingId)
    {
        var evaluations = _eventEvaluationRepository.Find(e=> e.RatingValueId == ratingId).ToList();
        return _mapper.Map<List<EventEvaluationResponseDTO>>(evaluations);
    }

    public EventEvaluationResponseDTO GetEventEvaluationById(int evaluationId)
    {
        return _mapper.Map<EventEvaluationResponseDTO>(_eventEvaluationRepository.GetById(evaluationId));

    }

    public void CreateEventEvaluation(EventEvaluationRequestDTO evaluationRequestDTO)
    {
        var evaluation = _mapper.Map<EventEvaluation>(evaluationRequestDTO);
        _eventEvaluationRepository.Add(evaluation);
    }

    public bool DeleteEventEvaluation(int evaluationId)
    {
        var evaluation = _eventEvaluationRepository.GetById(evaluationId);
        if (evaluation != null)
        {
            _eventEvaluationRepository.Remove(evaluation);
            return true;
        }
        return false;
    }

    public bool UpdateEventEvaluation(EventEvaluationRequestDTO evaluationRequestDTO)
    {
        var evaluation = _eventEvaluationRepository.GetById(evaluationRequestDTO.Id);
        if (evaluation != null)
        {
            var mapped = _mapper.Map<EventEvaluation>(evaluation);
            _eventEvaluationRepository.Update(mapped);
            return true;
        }
        return false;
    }
}
