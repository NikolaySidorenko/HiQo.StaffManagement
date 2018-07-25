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
    public class PositionProfiler:Profile
    {
        public PositionProfiler()
        {
            CreateMap<Position, PositionDto>()
                .ForMember(dto => dto.PositionId, cfg => cfg.MapFrom(src => src.PositionId))
                .ForMember(dto => dto.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(dto => dto.CategoryId, cfg => cfg.MapFrom(src => src.CategoryId))
                .ForMember(dto => dto.Category, cfg => cfg.MapFrom(src => src.Category))
                .ForMember(dto => dto.Users, cfg => cfg.MapFrom(src => src.Users));

        }
    }
}
