using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.EventEvaluation.Request;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Application.Services;
using EventBookingSystem.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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


    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Route("GetAll")]
    [HttpGet]
    public IActionResult GetAllEvaluations()
    {
        return Ok(_eventEvaluationService.GetEventEvaluations());
    }


    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Route("GetById")]
    [HttpGet]
    public IActionResult GetEvaluationById(int evaluationId)
    {
        return Ok(_eventEvaluationService.GetEventEvaluationById(evaluationId));
    }

    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Authorize(Roles = "User")]
    [Route("Create")]
    [HttpPost]
    public IActionResult CreateEvaluation(EventEvaluationRequestDTO eventEvaluationRequestDTO)
    {
        _eventEvaluationService.CreateEventEvaluation(eventEvaluationRequestDTO);
        return Ok("Successfully created");
    }

    [Authorize(Roles = "Admin")]
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

    [Authorize(Roles = "Admin")]
    [Route("Update")]
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
