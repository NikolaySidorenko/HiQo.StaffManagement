using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionRepository:BaseRepository,IPositionRepositiry
    {
        public PositionRepository(CompanyContext dbContext) : base(dbContext)
        {
        }
    }
}
