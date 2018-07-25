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

        }
    }
}
