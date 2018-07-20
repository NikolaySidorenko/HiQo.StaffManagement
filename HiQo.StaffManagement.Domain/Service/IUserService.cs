using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.Service
{
    public interface IUserService
    {
        TEntitiy GetByUserName<TEntitiy>(string userName) where TEntitiy : class;
        IEnumerable<TEntity> GetByDepartment<TEntity>(string department) where TEntity : class;
        IEnumerable<TEntity> GetByCategory<TEntity>(string category) where TEntity : class;
        IEnumerable<TEntity> GetByPosition<TEntity>(string position) where TEntity : class;
        IEnumerable<TEntity> GetByPositionLevel<TEntity>(string positionLevel) where TEntity : class;
        IEnumerable<TEntity> GetByRole<TEntity>(string role) where TEntity : class;
        IEnumerable<TEntity> GetByAge<TEntity>(int age) where TEntity : class;
    }
}
