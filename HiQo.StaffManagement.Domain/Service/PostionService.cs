using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class PostionService:IPositionService
    {
        private readonly IPositionRepositiry _repositiry;

        public PostionService(IPositionRepositiry repositiry)
        {
            _repositiry = repositiry;
        }

        public IEnumerable<PositionDto> GetAll()
        {
            return _repositiry.GetAll<PositionDto>();
        }

        public PositionDto GetById(int id)
        {
            return _repositiry.GetById<PositionDto>(id); 
        }

        public IEnumerable<PositionDto> GetByCategoryId(int id)
        {
            return _repositiry.GetAll<PositionDto>().Where(p => p.CategoryId == id);
        }
    }
}
