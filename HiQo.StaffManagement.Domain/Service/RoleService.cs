using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class RoleService:IRoleSerivice
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
