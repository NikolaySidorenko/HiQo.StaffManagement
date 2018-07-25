using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;

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
                .ForMember(category => category.Users, cfg => cfg.MapFrom(src => src.Users));
        }
    }
}
