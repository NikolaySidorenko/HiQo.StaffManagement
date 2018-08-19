using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Domain.Repositories
{
    public interface IRepository
    {
        IEnumerable<TDto> GetAll<TDto>();

        void Create<TDto>(TDto entity) where TDto : class;

        void DeleteById<TDto>(int id) where TDto : class;

        TDto GetById<TDto>(int id) where TDto : class;

        void Update<TDto>(TDto entity) where TDto : class;

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
