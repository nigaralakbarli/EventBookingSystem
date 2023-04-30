using EventBookingSystem.Application.DTOs.Authentication.Request;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Domain.Repositories.EntityRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;

        public AuthService(IUserRepository userRepository, IConfiguration config)
        {
            _userRepository = userRepository;
            _config = config;
        }

        public User Authenticate(LoginDTO login)
        {
            //var currentUser = _dbContext.Users.FirstOrDefault(o => o.Name.ToLower() == userLogin.Name.ToLower() && o.Password == userLogin.Password);
            var currentUser = _userRepository.Find(o => o.Email.ToLower() == login.Email.ToLower() && o.Password == login.Password).FirstOrDefault();
            if (currentUser != null)
            {
                return currentUser;
            }

            return null;
        }

        public string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Email),
                new Claim(ClaimTypes.Role, user.Role.Name)
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Audience"],
              claims,
              expires: DateTime.Now.AddMinutes(15),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
