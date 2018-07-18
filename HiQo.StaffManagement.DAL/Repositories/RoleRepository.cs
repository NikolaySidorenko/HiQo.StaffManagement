using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepositiry
    {
        public RoleRepository(CompanyContext context) : base(context)
        {
        }
    }
}