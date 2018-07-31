using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.DAL.Database;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class UserRepository: BaseRepository, IUserRepositiry
    {

        public UserRepository(CompanyContext dbContext) : base(dbContext)
        {

        }


    }
}
