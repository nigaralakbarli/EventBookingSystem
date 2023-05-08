using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.DTOs.EventEvaluation.Response;

public class EventEvaluationResponseDTO
{
    public int Id { get; set; }
    public string ExtraComment { get; set; }
    public string RatingValue { get; set; }
    public string EventTitle { get; set; }
}
