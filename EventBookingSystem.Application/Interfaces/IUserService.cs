using EventBookingSystem.Application.DTOs.User.Request;
using EventBookingSystem.Application.DTOs.User.Response;
using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.Interfaces;

public interface IUserService
{
    List<UserResponseDTO> GetUsers();
    UserResponseDTO GetUserById(int id);
    void CreateUser(UserCreateDTO userCreateDTO);
    bool UpdateUser(UserUpdateDTO userUpdateDto);
    bool DeleteUser(int userId);
}
