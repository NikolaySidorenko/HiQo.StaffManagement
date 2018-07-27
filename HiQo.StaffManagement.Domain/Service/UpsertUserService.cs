using System;
using System.Collections.Generic;
using AutoMapper;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class UpsertUserService:IUpsertUserService
    {
        private IUserRepositiry _userRepositiry;
        private IDepartmentRepositiry _departmentRepositiry;
        private IPositionLevelRepositiry _positionLevelRepositiry;
        private IRoleSrivice _roleSrivice;
        private ICategoryService _categoryService;
        private IPositionService _positionService;

        public UpsertUserService(IUserRepositiry userRepositiry, IDepartmentRepositiry departmentRepositiry,
            IPositionLevelRepositiry positionLevelRepositiry, IRoleSrivice roleSrivice, ICategoryService categoryService, IPositionService positionService)
        {
            _userRepositiry = userRepositiry;
            _departmentRepositiry = departmentRepositiry;
            _positionLevelRepositiry = positionLevelRepositiry;
            _roleSrivice = roleSrivice;
            _categoryService = categoryService;
            _positionService = positionService;
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _userRepositiry.GetAll<UserDto>();
        }

        public UserDto GetById(int id)
        {
            return _userRepositiry.GetById<UserDto>(id);
        }

        public void Create(UserDto user)
        {
            _userRepositiry.Create(user);
            _userRepositiry.SaveChanges();
        }

        public void Update(UserDto user)
        {
           _userRepositiry.Update(user);
           _userRepositiry.SaveChanges();
        }

        public IEnumerable<CategoryDto> GetCategoriesByDepartmentId(int id)
        {
            return _categoryService.GetByDepartmentId(id);
        }

        public IEnumerable<PositionDto> GetPositinsByCategoryId(int id)
        {
            return _positionService.GetByCategoryId(id);
        }

        public SharedInfoDto GetSharedInfo()
        {
            SharedInfoDto info=new SharedInfoDto();
            info.Departments = _departmentRepositiry.GetAll<DepartmentDto>();
            info.Categories = _categoryService.GetAll();
            info.Positions = _positionService.GetAll();
            info.Grades = _positionLevelRepositiry.GetAll<GradeDto>();
            info.Roles = _roleSrivice.GetAll();
            return info;
        }
    }
}
