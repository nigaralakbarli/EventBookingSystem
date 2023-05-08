using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.Category.Response;
using EventBookingSystem.Application.DTOs.EventEvaluation.Request;
using EventBookingSystem.Application.DTOs.EventEvaluation.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces;

public interface IEventEvaluationService
{
    List<EventEvaluationResponseDTO> GetEventEvaluations();
    List<EventEvaluationResponseDTO> GetByRatingValue(int ratingId);
    EventEvaluationResponseDTO GetEventEvaluationById(int eventEvaluationId );
    void CreateEventEvaluation(EventEvaluationRequestDTO evaluationRequestDTO);
    bool UpdateEventEvaluation(EventEvaluationRequestDTO evaluationRequestDTO);
    bool DeleteEventEvaluation(int evaluationId);  
}
