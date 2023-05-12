using AutoMapper;
using EventBookingSystem.Application.DTOs.EventEvaluation.Response;
using EventBookingSystem.Application.DTOs.Participant.Response;
using EventBookingSystem.Application.Helper.ExcelFile;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Repositories.EntityRepositories;

namespace EventBookingSystem.Application.Services;

public class ReportService : IReportService
{
    private readonly IExcelFile _excelFile;
    private readonly IMapper _mapper;
    private readonly IEventEvaluationRepository _eventEvaluationRepository;
    private readonly IParticipantRepository _participantRepository;

    public ReportService(
        IExcelFile excelFile,
        IMapper mapper,
        IEventEvaluationRepository eventEvaluationRepository,
        IParticipantRepository participantRepository)
    {
        _excelFile = excelFile;
        _mapper = mapper;
        _eventEvaluationRepository = eventEvaluationRepository;
        _participantRepository = participantRepository;
    }
    public List<EventEvaluationResponseDTO> EvaluationByEvent(int eventId)
    {
        return _mapper.Map<List<EventEvaluationResponseDTO>>(_eventEvaluationRepository.Find(e=> e.EventId == eventId).ToList());
    }

    public List<ParticipantResponseDTO> ParticipantsByEvent(int eventId)
    {
        return _mapper.Map<List<ParticipantResponseDTO>>(_participantRepository.Find(e => e.EventId == eventId).ToList());
    }

    public byte[] ExcelFileForEvaluationByEvent(int eventId)
    {
        return _excelFile.GenerateExcelFile(EvaluationByEvent(eventId));
    }

    public byte[] ExcelFileForParticipantsByEvent(int eventId)
    {
        return _excelFile.GenerateExcelFile(ParticipantsByEvent(eventId));
    }

}
