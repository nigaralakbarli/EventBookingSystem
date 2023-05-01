using AutoMapper;
using EventBookingSystem.Application.DTOs.Authentication.Request;
using EventBookingSystem.Application.DTOs.User.Request;
using EventBookingSystem.Application.DTOs.User.Response;
using EventBookingSystem.Application.Interfaces;
using EventBookingSystem.Domain.Entities;
using EventBookingSystem.Domain.Repositories.EntityRepositories;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<UserResponseDTO> GetUsers()
        {
            var users = _userRepository.GetAll().ToList();
            return _mapper.Map<List<UserResponseDTO>>(users);
            
        }

        public UserResponseDTO GetUserById(int id)
        {
            var user = _userRepository.GetById(id);
            return _mapper.Map<UserResponseDTO>(user);
        }

        public bool UpdateUser(int userId, UserUpdateDTO userUpdateDTO)
        {
            var user = _userRepository.GetById(userId);
            if(user != null)
            {
                var mapped = _mapper.Map<User>(userUpdateDTO);
                _userRepository.Update(mapped);
                return true;
            }
            return false;
            
        }

        public bool DeleteUser(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user!=null)
            {
                _userRepository.Remove(user);
                return true;
            }
            return false;
        }

        public void CreateUser(UserCreateDTO userCreateDTO)
        {
            var user = _mapper.Map<User>(userCreateDTO);
            _userRepository.Add(user);
        }
    }
}
