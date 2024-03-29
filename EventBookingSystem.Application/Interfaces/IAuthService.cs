﻿using EventBookingSystem.Application.DTOs.Authentication.Request;
using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces;

public interface IAuthService
{
    string Generate(User user);
    User Authenticate(LoginDTO login);
    string Registration(RegistrationDTO registrationDTO);
    string Login(LoginDTO login);
}
