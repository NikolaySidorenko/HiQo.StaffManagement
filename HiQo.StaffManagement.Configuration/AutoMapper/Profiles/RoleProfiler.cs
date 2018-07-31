using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profiles
{
    public class RoleProfiler:Profile
    {
        public RoleProfiler()
        {
            CreateMap<Role, RoleDto>()
                .ForMember(dto => dto.RoleId, cfg => cfg.MapFrom(src => src.RoleId))
                .ForMember(dto => dto.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(dto => dto.Users, cfg => cfg.MapFrom(src=>src.Users))
                .ReverseMap();
        }
    }
}
