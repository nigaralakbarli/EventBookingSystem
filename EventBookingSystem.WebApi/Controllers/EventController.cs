using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.Event.Request;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers;

[Route("Event")]
[ApiController]
public class EventController : ControllerBase
{
    private readonly IEventService _eventService;
    public EventController(IEventService eventService)
    {
        _eventService = eventService;
    }


    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Authorize(Roles = "User")]
    [Route("GetAll")]
    [HttpGet]
    public IActionResult GetAll() 
    {
        return Ok(_eventService.GetEvents());
    }


    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Authorize(Roles = "User")]
    [Route("GetById")]
    [HttpGet]
    public IActionResult GetById(int eventId)
    {
        return Ok(_eventService.GetEventById(eventId));
    }


    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Route("Create")]
    [HttpPost]
    public IActionResult CreateEvent(EventCreateDTO eventCreateDTO)
    {
        _eventService.CreateEvent(eventCreateDTO);
        return Ok("Successfully created");
    }


    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Route("Update")]
    [HttpPut]
    public IActionResult UpdateEvent(EventUpdateDTO eventUpdateDTO)
    {
        if (_eventService.UpdateEvent(eventUpdateDTO))
        {
            return Ok("Successfully updated");
        }
        return BadRequest($"Event with ID {eventUpdateDTO.Id} not found.");
    }


    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Manager")]
    [Route("Delete")]
    [HttpDelete]
    public IActionResult DeleteEvent(int eventId)
    {
        if (_eventService.DeleteEvent(eventId))
        {
            return Ok("Successfully deleted");
        }
        return BadRequest($"Event with ID {eventId} not found.");
    }

}
