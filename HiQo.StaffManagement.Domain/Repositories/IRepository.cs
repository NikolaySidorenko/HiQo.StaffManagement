using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Domain.Repositories
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity);
        void DeleteById(int id);
        void Update(TEntity entity);
    }
}
