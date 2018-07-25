using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service
{
    public interface IRoleSrivice
    {
        IEnumerable<RoleDto> GetAll();
        RoleDto GetById(int id);
    }
}
