using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Configuration.AutoMapper.Profiles
{
    public class CategoryProfiler:Profile
    {
        public CategoryProfiler()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(category => category.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(category => category.CategoryId, cfg => cfg.MapFrom(src => src.CategoryId))
                .ForMember(category => category.DepartmentId, cfg => cfg.MapFrom(src => src.DepartmentId))
                .ForMember(category => category.Department, cfg => cfg.MapFrom(src => src.Department))
                .ForMember(category => category.Positions, cfg => cfg.MapFrom(src => src.Positions))
                .ForMember(category => category.Users, cfg => cfg.MapFrom(src => src.Users))
                .ReverseMap();

            CreateMap<CategoryDto, CategoryViewModel>()
                .ForMember(category => category.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(category => category.CategoryId, cfg => cfg.MapFrom(src => src.CategoryId))
                .ForMember(category => category.DepartmentId, cfg => cfg.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.SharedInfo, cfg => cfg.Ignore())
                .ReverseMap();
        }
    }
}
