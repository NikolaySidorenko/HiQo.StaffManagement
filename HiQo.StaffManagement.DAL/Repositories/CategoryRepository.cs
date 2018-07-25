using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class CategoryRepository :BaseRepository,ICategoryRepositiry
    {
        public CategoryRepository(CompanyContext dbContext) : base(dbContext)
        {
        }
    }
}
