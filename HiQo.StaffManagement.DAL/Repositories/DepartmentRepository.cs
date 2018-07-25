using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class DepartmentRepository :BaseRepository,IDepartmentRepositiry
    {
        public DepartmentRepository(CompanyContext dbContext) : base(dbContext)
        {
        }
    }
}
