using AutoMapper;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Web.Core.Models;

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

            CreateMap<PositionDto, PositionViewModel>()
                .ForMember(dto => dto.PositionId, cfg => cfg.MapFrom(src => src.PositionId))
                .ForMember(dto => dto.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(dto => dto.CategoryId, cfg => cfg.MapFrom(src => src.CategoryId))
                .ReverseMap()
                .ForMember(dto => dto.Users, cfg => cfg.Ignore())
                .ForMember(dto => dto.Category, cfg => cfg.Ignore());

        }
    }
}
