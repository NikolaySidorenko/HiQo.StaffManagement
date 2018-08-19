using System.Threading.Tasks;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.Domain.Repositories
{
    public interface IUserRepositiry :IRepository
    {
        bool IsValid(string firstName, string lastName,int id);

        int GetLastId();

        UserDto GetToLogIn(string email, string password);

        Task<UserDto> FindByIdAsync(int userId);

        Task<UserDto> FindByNameAsync(string userName);
    }
}
