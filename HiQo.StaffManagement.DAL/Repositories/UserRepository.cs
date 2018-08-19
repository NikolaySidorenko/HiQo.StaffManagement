using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class UserRepository: BaseRepository, IUserRepositiry
    {
        private readonly IDbSet<User> _users;
        
        public UserRepository(CompanyContext dbContext) : base(dbContext)
        {
            _users = dbContext.Users;
        }

        public bool IsValid(string firstName, string lastName,int id)
        {
            var users= _users.Where(u => u.FirstName.ToLower() == firstName.ToLower()
                                          && u.LastName.ToLower() == lastName.ToLower()).ToList();

            if (users.Any())
            {
                bool isUpdate = false;
                foreach (var user in users)
                {
                     isUpdate=user.Id == id;
                }

                return isUpdate;
            }

            return !users.Any();
        }

        public int GetLastId()
        {
            return _users.ToList().Last().Id;
        }

        public UserDto GetToLogIn(string email, string password)
        {
            var user = _users.First(us => us.Email.Equals(email) && us.PasswordHash.Equals(password));
            return Mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> FindByIdAsync(int userId)
        {
            return Mapper.Map<UserDto>(await _users.SingleAsync(user=>user.Id==userId));
        }

        public async Task<UserDto> FindByNameAsync(string userName)
        {
            return Mapper.Map<UserDto>(await _users.Where(user => user.UserName.Equals(userName)).FirstAsync());
        }

    }
}
