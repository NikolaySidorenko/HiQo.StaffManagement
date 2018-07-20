using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionLevelRepository :BaseRepository,IPositionLevelRepositiry
    {
        public PositionLevelRepository(CompanyContext dbContext) : base(dbContext)
        {
        }
    }
}
