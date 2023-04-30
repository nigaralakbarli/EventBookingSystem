﻿using System.ComponentModel.DataAnnotations;

namespace EventBookingSystem.Application.DTOs.Authentication.Request
{
    public class RegistrationDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
