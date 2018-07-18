using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    class UserRepository:BaseRepository<User>,IUserRepositiry 
    {
        public UserRepository(CompanyContext context) : base(context)
        {
        }
    }
}
