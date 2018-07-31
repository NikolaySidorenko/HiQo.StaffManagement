using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class DepartmentRepository :BaseRepository, IDepartmentRepositiry
    {
        public DepartmentRepository(CompanyContext dbContext) : base(dbContext)
        {
        }

        
    }
}
