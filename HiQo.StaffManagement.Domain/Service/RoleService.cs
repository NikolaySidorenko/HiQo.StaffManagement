using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.Domain.Service
{
    public class RoleService:IRoleSrivice
    {
        private readonly IRoleRepositiry _repositiry;

        public RoleService(IRoleRepositiry repositiry)
        {
            _repositiry = repositiry;
        }

        public IEnumerable<RoleDto> GetAll()
        {
            return _repositiry.GetAll<RoleDto>();
        }

        public RoleDto GetById(int id)
        {
            return _repositiry.GetById<RoleDto>(id);
        }
    }
}
