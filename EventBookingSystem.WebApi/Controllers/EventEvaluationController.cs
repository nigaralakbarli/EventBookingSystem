using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.EventEvaluation.Request;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Application.Services;
using EventBookingSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers;

[Route("EventEvaluation")]
[ApiController]
public class EventEvaluationController : ControllerBase
{
    private readonly IEventEvaluationService _eventEvaluationService;

    public EventEvaluationController(
        IEventEvaluationService eventEvaluationService)
    {
        _eventEvaluationService = eventEvaluationService;
    }

    [Route("GetAll")]
    [HttpGet]
    public IActionResult GetAllEvaluations()
    {
        return Ok(_eventEvaluationService.GetEventEvaluations());
    }

    [Route("GetById")]
    [HttpGet]
    public IActionResult GetEvaluationById(int evaluationId)
    {
        return Ok(_eventEvaluationService.GetEventEvaluationById(evaluationId));
    }

    [Route("Create")]
    [HttpPost]
    public IActionResult CreateEvaluation(EventEvaluationRequestDTO eventEvaluationRequestDTO)
    {
        _eventEvaluationService.CreateEventEvaluation(eventEvaluationRequestDTO);
        return Ok("Successfully created");
    }

    [Route("Delete")]
    [HttpDelete]
    public IActionResult DeleteEvaluation(int evaluationId)
    {
        if (_eventEvaluationService.DeleteEventEvaluation(evaluationId))
        {
            return Ok("Successfully deleted");
        }
        return BadRequest($"Evaluation with ID {evaluationId} not found.");
    }

    [Route("Delete")]
    [HttpPut]
    public IActionResult UpdateEvaluation(EventEvaluationRequestDTO eventEvaluationRequestDTO)
    {
        if (_eventEvaluationService.UpdateEventEvaluation(eventEvaluationRequestDTO))
        {
            return Ok("Successfully updated");
        }
        return BadRequest($"Evaluation with ID {eventEvaluationRequestDTO.Id} not found.");
    }
}
