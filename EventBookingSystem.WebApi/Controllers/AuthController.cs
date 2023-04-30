using EventBookingSystem.Application.DTOs.Authentication.Request;
using EventBookingSystem.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromQuery] LoginDTO userLogin)
        {
            var user = _authService.Authenticate(userLogin);

            if (user != null)
            {
                var token = _authService.Generate(user);
                return Ok(token);
            }

            return NotFound("User not found");
        }
    }
}
