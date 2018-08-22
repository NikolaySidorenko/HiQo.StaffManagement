using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profiles
{
    public class UserProfiler : Profile
    {
        public UserProfiler()
        {
            CreateMap<User, UserDto>()
                .ForMember(userDto => userDto.Id, cfg => cfg.MapFrom(src => src.Id))
                .ForMember(userDto => userDto.FirstName,cfg=>cfg.MapFrom(src=>src.FirstName))
                .ForMember(userDto => userDto.LastName, cfg => cfg.MapFrom(src => src.LastName))
                .ForMember(userDto => userDto.UserName, cfg => cfg.MapFrom(src => src.UserName))
                .ForMember(userDto => userDto.Email, cfg => cfg.MapFrom(src => src.Email))
                .ForMember(userDto => userDto.Password, cfg => cfg.MapFrom(src => src.PasswordHash))
                .ForMember(userDto => userDto.DateOfBirth, cfg => cfg.MapFrom(src => src.DateOfBirth))
                .ForMember(userDto => userDto.DepartmentId, cfg => cfg.MapFrom(src => src.DepartmentId))
                .ForMember(userDto => userDto.Department, cfg => cfg.MapFrom(src => src.Department))
                .ForMember(userDto => userDto.CategoryId, cfg => cfg.MapFrom(src => src.CategoryId))
                .ForMember(userDto => userDto.Category, cfg => cfg.MapFrom(src => src.Category))
                .ForMember(userDto => userDto.PositionId, cfg => cfg.MapFrom(src => src.PositionId))
                .ForMember(userDto => userDto.Position, cfg => cfg.MapFrom(src => src.Position))
                .ForMember(userDto => userDto.RoleId, cfg => cfg.MapFrom(src => src.RoleId))
                .ForMember(userDto => userDto.Role, cfg => cfg.MapFrom(src => src.Role))
                .ForMember(userDto => userDto.GradeId, cfg => cfg.MapFrom(src => src.PositionLevelId))
                .ForMember(userDto => userDto.Grade, cfg => cfg.MapFrom(src => src.PositionLevel))
                .ReverseMap();



            CreateMap<UserDto, UpsertUser>()
                .ForMember(user => user.UserId, cfg => cfg.MapFrom(dto => dto.Id))
                .ForMember(user => user.FirstName, cfg => cfg.MapFrom(dto => dto.FirstName))
                .ForMember(user => user.LastName, cfg => cfg.MapFrom(dto => dto.LastName))
                .ForMember(user => user.UserName, cfg => cfg.MapFrom(dto => dto.UserName))
                .ForMember(user => user.Email, cfg => cfg.MapFrom(dto => dto.Email))
                .ForMember(user => user.Password, cfg => cfg.MapFrom(dto => dto.Password))
                .ForMember(user => user.DateOfBirth, cfg => cfg.MapFrom(dto => dto.DateOfBirth))
                .ForMember(user => user.DepartmentId, cfg => cfg.MapFrom(dto => dto.DepartmentId))
                .ForMember(user => user.CategoryId, cfg => cfg.MapFrom(dto => dto.CategoryId))
                .ForMember(user => user.PositionId, cfg => cfg.MapFrom(dto => dto.PositionId))
                .ForMember(user => user.GradeId, cfg => cfg.MapFrom(dto => dto.GradeId))
                .ForMember(user => user.RoleId, cfg => cfg.MapFrom(dto => dto.RoleId))
                .ReverseMap()
                .ForMember(userDto => userDto.Department, cfg => cfg.Ignore())
                .ForMember(userDto => userDto.Category, cfg => cfg.Ignore())
                .ForMember(userDto => userDto.Position, cfg => cfg.Ignore())
                .ForMember(userDto => userDto.Grade, cfg => cfg.Ignore())
                .ForMember(userDto => userDto.Role, cfg => cfg.Ignore());

            CreateMap<RegisterViewModel, UserDto>()
                .ForMember(user => user.Email, cfg => cfg.MapFrom(regUser => regUser.Email))
                .ForMember(user => user.Password, cfg => cfg.MapFrom(regUser => regUser.Password))
                .ForMember(user => user.FirstName, cfg => cfg.MapFrom(regUser => regUser.FirstName))
                .ForMember(user => user.LastName, cfg => cfg.MapFrom(regUser => regUser.LastName))
                .ForMember(user => user.DateOfBirth, cfg => cfg.MapFrom(regUser => regUser.DateOfBirth))
                .ForMember(user => user.UserName, cfg => cfg.MapFrom(regUser => regUser.UserName));


        }
    }
}