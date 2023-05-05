using EventBookingSystem.Application.DTOs.Venue.Request;
using EventBookingSystem.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers
{
    [Route("VenueController")]
    [ApiController]
    public class VenueController : ControllerBase
    {
        private readonly IVenueService _venueService;
        public VenueController(IVenueService venueService)
        {
            _venueService = venueService;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetVenues() 
        {
            return Ok(_venueService.GetVenues());
        }

        [Route("GetById")]
        [HttpGet]
        public IActionResult GetVenue(int id)
        {
            return Ok(_venueService.GetVenueById(id));
        }

        [Route("CreateVenue")]
        [HttpPost]
        public IActionResult CreateVenue(VenueRequestDTO venueCreateDTO)
        {
            _venueService.CreateVenue(venueCreateDTO);
            return Ok();
        }

        [Route("DeleteVenue")]
        [HttpDelete]
        public IActionResult DeleteVenue(int id)
        {
            if(_venueService.DeleteVenue(id))
            {
                return Ok();
            }
            return BadRequest("Venue does not exist");
        }

    }
}
