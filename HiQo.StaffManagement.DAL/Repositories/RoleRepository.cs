using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;
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