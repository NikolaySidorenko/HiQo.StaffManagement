using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class DepartmentRepository :BaseRepository<Department>,IDepartmentRepositiry
    {
        public DepartmentRepository(CompanyContext context) : base(context)
        {
        }
    }
}
