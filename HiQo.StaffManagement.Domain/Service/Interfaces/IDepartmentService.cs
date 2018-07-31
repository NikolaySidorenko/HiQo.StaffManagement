using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentDto> GetAll();
        DepartmentDto GetById(int id);
        void Upsert(DepartmentDto department);
    }
}
