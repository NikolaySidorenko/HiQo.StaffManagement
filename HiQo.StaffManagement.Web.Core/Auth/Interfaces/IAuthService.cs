using System.Security.Claims;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Web.Core.Models;

namespace HiQo.StaffManagement.Web.Core.Auth.Interfaces
{
    public interface IAuthService
    {
        void RegisterUser(UserDto user);

        ClaimsIdentity CreateLoginIdentity(UserDto user,string authenticationType);

        UserDto IsUserExists(LogInViewModel user);

    }
}
