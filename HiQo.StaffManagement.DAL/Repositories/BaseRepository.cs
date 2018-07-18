using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class

    {
        protected CompanyContext _context;

        protected DbSet<TEntity> _dbSet;

        protected BaseRepository(CompanyContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.AsNoTracking().Where(expression).ToList();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void DeleteById(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity ?? throw new NullReferenceException());
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}