using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service.Interfaces
{
    public interface IUpsertUserService
    {
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
        void Create(UserDto user);
        void Update(UserDto user);
        IEnumerable<CategoryDto> GetCategoriesByDepartmentId(int id);
        IEnumerable<PositionDto> GetPositinsByCategoryId(int id);
        SharedInfoDto GetSharedInfo();
    }
}
