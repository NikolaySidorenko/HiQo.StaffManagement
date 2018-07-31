using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class RoleRepository : BaseRepository, IRoleRepositiry
    {
        public RoleRepository(CompanyContext dbContext) : base(dbContext)
        {
            
        }
    }
}