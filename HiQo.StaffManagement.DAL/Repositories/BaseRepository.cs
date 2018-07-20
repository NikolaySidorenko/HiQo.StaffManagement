using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.Domain.Repositories;
using AutoMapper;
namespace HiQo.StaffManagement.DAL.Repositories
{
    public class BaseRepository : IRepository
    {
        protected CompanyContext DbContext;

        protected BaseRepository(CompanyContext dbContext)
        {
            DbContext = dbContext;
        }


        public ICollection<TDto> GetAll<TEntity, TDto>() where TEntity : class where TDto : class
        {
            throw new NotImplementedException();
        }

        public TDto GetById<TEntity, TDto>(int id) where TEntity : class where TDto : class
        {
            var entity = DbContext.Set<TEntity>().Find(id);
            var dto= Mapper.Map<TEntity, TDto>(entity);
            return dto;
        }

        public ICollection<TDto> Get<TEntity, TDto>(Expression<Func<TEntity, bool>> expression) where TEntity : class where TDto : class
        {
            var entities = DbContext.Set<TEntity>().Where(expression);
            ICollection<TDto> Dtos=new List<TDto>();
            foreach (var entity in entities)
            {
                Dtos.Add(Mapper.Map<TEntity,TDto>(entity));
            }

            return Dtos;
        }

        public void Create<TEntity, TDto>(TEntity entity) where TEntity : class where TDto : class
        {
            throw new NotImplementedException();
        }

        public void DeleteById<TEntity, TDto>(int id) where TEntity : class where TDto : class
        {
            throw new NotImplementedException();
        }

        public void Update<TEntity, TDto>(TEntity entity) where TEntity : class where TDto : class
        {
            throw new NotImplementedException();
        }
    }
}