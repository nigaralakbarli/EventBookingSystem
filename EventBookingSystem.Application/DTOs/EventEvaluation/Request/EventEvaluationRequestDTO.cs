using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.DTOs.EventEvaluation.Request;

public class EventEvaluationRequestDTO
{
    public int Id { get; set; }
    public string? ExtraComment { get; set; }
    public int RatingValueId { get; set; }
    public int EventId { get; set; }
}
