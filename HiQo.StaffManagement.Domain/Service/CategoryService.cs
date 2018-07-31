using System;
using System.Collections.Generic;
using System.Linq;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Domain.Service
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepositiry _repository;
        private readonly ISharedService _service;

        public CategoryService(ICategoryRepositiry repositiry, ISharedService service)
        {
            _repository = repositiry;
            _service = service;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return _repository.GetAll<CategoryDto>();
        }

        public CategoryDto GetById(int id)
        {
            return  _repository.GetById<CategoryDto>(id);
        }

        public IEnumerable<CategoryDto> GetByDepartmentId(int id)
        {
            var categories=  _repository.GetAll<CategoryDto>().Where(c=>c.DepartmentId==id);
            return categories;
        }

        public void Upsert(CategoryDto entity)
        {
            throw new NotImplementedException();
        }

        public SharedInfoDto GetSharedInfo()
        {
            return _service.GetSharedInfo();
        }
    }
}
