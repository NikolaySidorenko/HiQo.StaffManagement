using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Service.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
        void Update(UserDto user);
    }
}
