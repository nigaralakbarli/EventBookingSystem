using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.Category.Response;
using EventBookingSystem.Application.DTOs.Participant.Request;
using EventBookingSystem.Application.DTOs.Participant.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces;

public interface IParticipantService
{
    List<ParticipantResponseDTO> GetParticipants();
    ParticipantResponseDTO GetParticipantById(int participantId);
    List<ParticipantResponseDTO> GetParticipantsByEvent(int eventId);
    void CreateParticipant(ParticipantRequestDTO participantRequestDTO);
    bool UpdateParticipant(ParticipantRequestDTO participantRequestDTO);
    bool DeleteParticipant(int participantId);  
}
