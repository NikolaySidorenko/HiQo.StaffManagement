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

        public CategoryService(ICategoryRepositiry repositiry)
        {
            _repository = repositiry;
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
            return  _repository.GetAll<CategoryDto>().Where(c=>c.DepartmentId==id);  
        }

        public void Upsert(CategoryDto entity)
        {
            if(entity.CategoryId==0)
                _repository.Create(entity);
            else
                _repository.Update(entity);
        }
    }
}
