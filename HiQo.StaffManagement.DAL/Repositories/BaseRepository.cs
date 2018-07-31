using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public abstract class BaseRepository :IRepository
    {
        protected CompanyContext DbContext;

        protected BaseRepository(CompanyContext dbContext)
        {
            DbContext = dbContext;       
        }

        public IEnumerable<TDto> GetAll<TDto>()
        {
            if (typeof(TDto) == typeof(UserDto))
                return Mapper.Map<IEnumerable<TDto>>(DbContext.Users.ToList());
            if (typeof(TDto) == typeof(DepartmentDto))
                return Mapper.Map<IEnumerable<TDto>>(DbContext.Departments.ToList());
            if (typeof(TDto) == typeof(CategoryDto))
                return Mapper.Map<IEnumerable<TDto>>(DbContext.Categories.ToList());
            if (typeof(TDto) == typeof(PositionDto))
                return Mapper.Map<IEnumerable<TDto>>(DbContext.Positions.ToList());
            if (typeof(TDto) == typeof(GradeDto))
                return Mapper.Map<IEnumerable<TDto>>(DbContext.PositionLevels.ToList());
            if (typeof(TDto) == typeof(RoleDto))
                return Mapper.Map<IEnumerable<TDto>>(DbContext.Roles.ToList());
            throw new Exception();
        }

        public void Create<TDto>(TDto entity) where TDto : class
        {
            if (typeof(TDto) == typeof(UserDto))
            {
                var user= Mapper.Map<User>(entity);
                DbContext.Users.Add(user);
                return;
            }

            if (typeof(TDto) == typeof(DepartmentDto))
            {
                var department = Mapper.Map<Department>(entity);
                DbContext.Departments.Add(department);
                return;
            }

            if (typeof(TDto) == typeof(CategoryDto))
            {
                var category = Mapper.Map<Category>(entity);
                DbContext.Categories.Add(category);
                return;
            }

            if (typeof(TDto) == typeof(PositionDto))
            {
                var position = Mapper.Map<Position>(entity);
                DbContext.Positions.Add(position);
                return;
            }

            if (typeof(TDto) == typeof(GradeDto))
            {
                var positionLevel = Mapper.Map<PositionLevel>(entity);
                DbContext.PositionLevels.Add(positionLevel);
                return;
            }

            if (typeof(TDto) == typeof(RoleDto))
            {
                var role = Mapper.Map<Role>(entity);
                DbContext.Roles.Add(role);
                return;
            }
            throw new Exception();

        }

        public void DeleteById<TDto>(int id) where TDto : class
        {
            if (typeof(TDto) == typeof(UserDto))
            {
                var entity=DbContext.Users.Find(id);
                DbContext.Users.Remove(entity);
                return;
            }

            if (typeof(TDto) == typeof(DepartmentDto))
            {
                var entity = DbContext.Departments.Find(id);
                DbContext.Departments.Remove(entity);
                return;
            }

            if (typeof(TDto) == typeof(CategoryDto))
            {
                var entity = DbContext.Categories.Find(id);
                DbContext.Categories.Remove(entity);
                return;
            }

            if (typeof(TDto) == typeof(PositionDto))
            {
                var entity = DbContext.Positions.Find(id);
                DbContext.Positions.Remove(entity);
                return;
            }

            if (typeof(TDto) == typeof(GradeDto))
            {
                var entity = DbContext.PositionLevels.Find(id);
                DbContext.PositionLevels.Remove(entity);
                return;
            }

            if (typeof(TDto) == typeof(RoleDto))
            {
                var entity = DbContext.Roles.Find(id);
                DbContext.Roles.Remove(entity);
                return;
            }

            throw new Exception();
        }

        public TDto GetById<TDto>(int id) where TDto : class
        {
            if (typeof(TDto) == typeof(UserDto))
            {
                 return Mapper.Map<TDto>(DbContext.Users.Find(id));
            }

            if (typeof(TDto) == typeof(DepartmentDto))
            {
                return Mapper.Map<TDto>(DbContext.Departments.Find(id));
            }

            if (typeof(TDto) == typeof(CategoryDto))
            {
                return Mapper.Map<TDto>(DbContext.Categories.Find(id));
            }

            if (typeof(TDto) == typeof(PositionDto))
            {
                return Mapper.Map<TDto>(DbContext.Positions.Find(id));
            }

            if (typeof(TDto) == typeof(GradeDto))
            {
                return Mapper.Map<TDto>(DbContext.PositionLevels.Find(id));
            }

            if (typeof(TDto) == typeof(RoleDto))
            {
                return Mapper.Map<TDto>(DbContext.Roles.Find(id));
            }

            throw new Exception();
        }

        public void Update<TDto>(TDto entity) where TDto : class
        {
            if (typeof(TDto) == typeof(UserDto))
            {
                var user = Mapper.Map<User>(entity);
                DbContext.Users.AddOrUpdate(us=>us.UserId,user);
                return;
            }

            if (typeof(TDto) == typeof(DepartmentDto))
            {
                var department = Mapper.Map<Department>(entity);
                DbContext.Departments.AddOrUpdate(dep => dep.DepartmentId, department);
                return;
            }

            if (typeof(TDto) == typeof(CategoryDto))
            {
                var category = Mapper.Map<Category>(entity);
                DbContext.Categories.AddOrUpdate(cat => cat.CategoryId, category);
                return;
            }

            if (typeof(TDto) == typeof(PositionDto))
            {
                var position = Mapper.Map<Position>(entity);
                DbContext.Positions.AddOrUpdate(pos => pos.PositionId, position);
                return;
            }

            if (typeof(TDto) == typeof(GradeDto))
            {
                var grade = Mapper.Map<PositionLevel>(entity);
                DbContext.PositionLevels.AddOrUpdate(pl => pl.PositionLevelId, grade);
                return;
            }

            if (typeof(TDto) == typeof(RoleDto))
            {
                var role = Mapper.Map<Role>(entity);
                DbContext.Roles.AddOrUpdate(rl => rl.RoleId, role);
                return;
            }
            throw new Exception();
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}