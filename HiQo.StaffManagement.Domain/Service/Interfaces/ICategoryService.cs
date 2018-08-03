using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        IEnumerable<CategoryDto> GetByDepartmentId(int id);
        void Upsert(CategoryDto entity);
    }
}
