using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service.Interfaces
{
    public interface IRoleSerivice
    {
        IEnumerable<RoleDto> GetAll();
        RoleDto GetById(int id);
    }
}
