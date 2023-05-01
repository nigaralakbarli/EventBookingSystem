using EventBookingSystem.Application.DTOs.User.Request;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EventBookingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //[Authorize(Roles = "Admin")]
        [Route("/GetAll")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            
            var users = _userService.GetUsers();
            return Ok(users);
        }

        //[Authorize(Roles = "Admin")]
        [Route("/GetById")]
        [HttpGet]
        public IActionResult GetUserById(int id)
        {

            var user = _userService.GetUserById(id);
            return Ok(user);
        }

        //[Authorize(Roles = "Admin")]
        [Route("/Create")]
        [HttpPost]
        public IActionResult Create(UserCreateDTO userCreateDTO)
        {
            _userService.CreateUser(userCreateDTO);
            return Ok();
        }

        //[Authorize(Roles = "Admin")]
        [Route("/Update")]
        [HttpPost]
        public IActionResult Update(int userId,UserUpdateDTO userUpdateDTO)
        {

            if (!_userService.UpdateUser(userId, userUpdateDTO))
            {
                return BadRequest($"User with ID {userId} not found.");
            }
            return Ok();
        }

        //[Authorize(Roles = "Admin")]
        [Route("/Delete")]
        [HttpDelete]
        public IActionResult DeleteUser(int userId)
        {
            if (!_userService.DeleteUser(userId))
            {
                return BadRequest($"User with ID {userId} not found.");
            }
            return Ok();
        }
    }
}
