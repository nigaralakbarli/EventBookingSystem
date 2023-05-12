using EventBookingSystem.Application.DTOs.EventEvaluation.Request;
using EventBookingSystem.Application.DTOs.EventEvaluation.Response;

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
