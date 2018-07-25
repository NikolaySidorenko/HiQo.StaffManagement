using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentRepositiry _repositiry;

        public DepartmentService(IDepartmentRepositiry repositiry)
        {
            _repositiry = repositiry;
        }

        public IEnumerable<DepartmentDto> GetAll()
        {
            return _repositiry.GetAll<DepartmentDto>();
        }

        public DepartmentDto GetById(int id)
        {
            return _repositiry.GetById<DepartmentDto>(id);
        }

    }
}
