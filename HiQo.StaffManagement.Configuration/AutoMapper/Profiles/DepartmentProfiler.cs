using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profiles
{
    public class DepartmentProfiler:Profile
    {
        public DepartmentProfiler()
        {
            CreateMap<Department, DepartmentDto>()
                .ForMember(department => department.DepartmentId, cfg => cfg.MapFrom(src => src.DepartmentId))
                .ForMember(department => department.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(department => department.Categories, cfg => cfg.MapFrom(src => src.Categories))
                .ForMember(department => department.Users, cfg => cfg.MapFrom(src => src.Users))
                .ReverseMap();

            CreateMap<DepartmentDto, DepartmentViewModel>()
                .ForMember(department => department.DepartmentId, cfg => cfg.MapFrom(src => src.DepartmentId))
                .ForMember(department => department.Name, cfg => cfg.MapFrom(src => src.Name))
                .ReverseMap()
                .ForMember(department => department.Categories, cfg => cfg.Ignore())
                .ForMember(department => department.Users, cfg => cfg.Ignore());

        }
    }
}
