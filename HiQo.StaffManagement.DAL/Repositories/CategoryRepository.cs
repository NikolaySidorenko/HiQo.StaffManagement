using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class CategoryRepository :BaseRepository<Category>,ICategoryRepositiry
    {
        public CategoryRepository(CompanyContext context) : base(context)
        {
        }
    }
}
