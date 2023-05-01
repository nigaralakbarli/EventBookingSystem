﻿using AutoMapper;
using EventBookingSystem.Application.DTOs.Authentication.Request;
using EventBookingSystem.Application.DTOs.User.Request;
using EventBookingSystem.Application.DTOs.User.Response;
using EventBookingSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Application.AutoMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<RegistrationDTO, User>();
            CreateMap<User, UserResponseDTO>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.Name)); ;

            CreateMap<UserUpdateDTO, User>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember, context) => srcMember != null));





            //.ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));





            //.ForMember(dest => dest.FirstName, opt =>
            //    opt.Condition(src => src.FirstName != null))
            //.ForMember(dest => dest.LastName, opt =>
            //    opt.Condition(src => src.LastName != null))
            //.ForMember(dest => dest.Email, opt =>
            //    opt.Condition(src => src.Email != null))
            //.ForMember(dest => dest.RoleId, opt =>
            //    opt.Condition(src => src.RoleId != null))
            //.ForMember(dest => dest.Password, opt =>
            //    opt.Condition(src => src.Password != null));


        }
    }
}