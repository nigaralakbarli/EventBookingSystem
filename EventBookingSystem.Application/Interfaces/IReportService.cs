using EventBookingSystem.Application.DTOs.EventEvaluation.Response;
using EventBookingSystem.Application.DTOs.Participant.Response;

namespace EventBookingSystem.Application.Interfaces;

public interface IReportService
{
    List<EventEvaluationResponseDTO> EvaluationByEvent(int eventId);
    List<ParticipantResponseDTO> ParticipantsByEvent(int eventId);
    byte[] ExcelFileForEvaluationByEvent(int eventId);
    byte[] ExcelFileForParticipantsByEvent(int eventId);

}
