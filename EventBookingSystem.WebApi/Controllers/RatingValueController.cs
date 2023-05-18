using EventBookingSystem.Application.DTOs.Category.Request;
using EventBookingSystem.Application.DTOs.RatingValue.Request;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers;

[Route("RatingValue")]
[ApiController]
public class RatingValueController : ControllerBase
{
    private readonly IRatingValueService _ratingValueService;

    public RatingValueController(
        IRatingValueService ratingValueService )
    {
        _ratingValueService = ratingValueService;
    }

    //[Authorize(Roles = "Admin")]
    [Route("GetAll")]
    [HttpGet]
    public IActionResult GetRatingValues()
    {
        return Ok(_ratingValueService.GetRatingValues());
    }

    //[Authorize(Roles = "Admin")]
    [Route("GetById")]
    [HttpGet]
    public IActionResult GetRatingValueById(int ratingId)
    {
        return Ok(_ratingValueService.GetRatingValueById(ratingId));
    }

    //[Authorize(Roles = "Admin")]
    [Route("Create")]
    [HttpPost]
    public IActionResult CreateRatingValue(RatingValueRequestDTO ratingValueRequestDTO)
    {
        _ratingValueService.CreateRatingValue(ratingValueRequestDTO);
        return Ok("Successfully created");
    }

    //[Authorize(Roles = "Admin")]
    [Route("Update")]   
    [HttpPut]
    public IActionResult UpdateRatingValue(RatingValueRequestDTO ratingValueRequestDTO)
    {
        if (_ratingValueService.UpdateRatingValue(ratingValueRequestDTO))
        {
            return Ok("Successfully updated");
        }
        return BadRequest($"RatingValue with ID {ratingValueRequestDTO.Id} not found.");
    }

    //[Authorize(Roles = "Admin")]
    [Route("Delete")]
    [HttpDelete]
    public IActionResult DeleteRatingValue(int ratingId)
    {
        if (_ratingValueService.DeleteRatingValue(ratingId))
        {
            return Ok("Successfully deleted");
        }
        return BadRequest($"RatingValue with ID {ratingId} not found.");
    }
}
