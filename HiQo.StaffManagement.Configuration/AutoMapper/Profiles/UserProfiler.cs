using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.DAL.Profiles
{
    public class UserProfiler : Profile
    {
        public UserProfiler()
        {
            CreateMap<User, UserDTO>().ForMember(user => user.Category, cfg => cfg.MapFrom(user => user.Category.Name))
                .ForMember(user => user.Role, cfg => cfg.MapFrom(user => user.Role.Name))
                .ForMember(userDto => userDto.Department, cfg => cfg.MapFrom(user => user.Department.Name))
                .ForMember(userDto => userDto.Category, cfg => cfg.MapFrom(user => user.Category.Name))
                .ForMember(userDto => userDto.Grade, cfg => cfg.MapFrom(user => user.PositionLevel.Name))
                .ForMember(userDto => userDto.GradeLevel, cfg => cfg.MapFrom(user => user.PositionLevel.Level))
                .ForMember(userDto => userDto.Position, cfg => cfg.MapFrom(user => user.Position.Name));
        }
    }
}