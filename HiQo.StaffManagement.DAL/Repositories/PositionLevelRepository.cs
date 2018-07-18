using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionLevelRepository :BaseRepository<PositionLevel>,IPositionLevelRepositiry
    {
        public PositionLevelRepository(CompanyContext context) : base(context)
        {
        }
    }
}
