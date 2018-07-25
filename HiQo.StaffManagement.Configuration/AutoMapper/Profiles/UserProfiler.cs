using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profiles
{
    public class UserProfiler : Profile
    {
        public UserProfiler()
        {
            CreateMap<User, UserDto>()
                .ForMember(userDto => userDto.UserId, cfg => cfg.MapFrom(src => src.UserId))
                .ForMember(userDto => userDto.FirstName,cfg=>cfg.MapFrom(src=>src.FirstName))
                .ForMember(userDto => userDto.LastName, cfg => cfg.MapFrom(src => src.LastName))
                .ForMember(userDto => userDto.UserName, cfg => cfg.MapFrom(src => src.UserName))
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
        }
    }
}