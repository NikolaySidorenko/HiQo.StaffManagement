using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using Xunit;

namespace HiQo.StaffManagement.Domain.Tests.Servicies
{
    public class CategoryServiceTests
    {
        private readonly ICategoryService _service;
        private readonly ICategoryRepositiry _fakeRepositiry;

        public CategoryServiceTests()
        {
            _fakeRepositiry = A.Fake<ICategoryRepositiry>();
            _service=new CategoryService(_fakeRepositiry);
        }

        [Fact]
        public void Upsert_NewCategory_MustCreateNew()
        {
            CategoryDto category = new CategoryDto {CategoryId = 0};

            _service.Upsert(category);

            A.CallTo(() => _fakeRepositiry.Create(category)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Upsert_OldCategory_MustUpdate()
        {
            CategoryDto category = new CategoryDto { CategoryId = 1 };

            _service.Upsert(category);

            A.CallTo(() => _fakeRepositiry.Update(category)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetByDepartmentId_DepartmentId_Categories()
        {
            List<CategoryDto> categories = new List<CategoryDto>
            {
                new CategoryDto {CategoryId = 1},
                new CategoryDto {CategoryId = 2},
                new CategoryDto {CategoryId = 3}
            };
            var categoriesId = new[] {1, 2, 3};
            int departmentId = 1;
            //A.CallTo(_fakeRepositiry).Where();

            var res = _service.GetByDepartmentId(departmentId).ToList();

            Assert.Equal(categoriesId.Length,res.Count);

            for (int i = 0; i < categoriesId.Length; i++)
            {
                Assert.Equal(categoriesId[i],res[i].CategoryId);
            }




        }
    }
}
