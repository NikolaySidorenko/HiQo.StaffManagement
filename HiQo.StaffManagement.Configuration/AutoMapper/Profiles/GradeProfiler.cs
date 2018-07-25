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
    public class GradeProfiler : Profile
    {
        public GradeProfiler()
        {
            CreateMap<PositionLevel, GradeDto>()
                .ForMember(dest => dest.GradeId, cfg => cfg.MapFrom(src => src.PositionLevelId))
                .ForMember(dest => dest.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(dest => dest.Level, cfg => cfg.MapFrom(src => src.Level))
                .ForMember(dest => dest.Users, cfg => cfg.MapFrom(src => src.Users))
                .ReverseMap();
        }
    }
}
