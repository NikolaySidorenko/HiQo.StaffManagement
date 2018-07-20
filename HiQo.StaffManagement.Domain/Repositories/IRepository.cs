using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HiQo.StaffManagement.Domain.Repositories
{
    public interface IRepository
    {
        ICollection<TDto> GetAll<TEntity, TDto>() where TDto : class 
            where TEntity : class;

        TDto GetById<TEntity,TDto>(int id) where TDto : class
            where TEntity : class;

        ICollection<TDto> Get<TEntity,TDto>(Expression<Func<TEntity, bool>> expression) where TDto : class
            where TEntity : class;

        void Create<TEntity,TDto>(TEntity entity) where TDto : class
            where TEntity : class;

        void DeleteById<TEntity,TDto>(int id) where TDto : class
            where TEntity : class;

        void Update<TEntity,TDto>(TEntity entity) where TDto : class
            where TEntity : class;
    }
}
