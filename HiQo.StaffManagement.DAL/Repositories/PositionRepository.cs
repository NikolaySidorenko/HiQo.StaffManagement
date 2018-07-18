using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionRepository:BaseRepository<Position>,IPositionRepositiry
    {
        public PositionRepository(CompanyContext context) : base(context)
        {
        }
    }
}
