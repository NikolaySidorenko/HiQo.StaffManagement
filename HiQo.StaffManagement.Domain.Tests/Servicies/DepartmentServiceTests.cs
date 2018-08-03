using FakeItEasy;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using Xunit;

namespace HiQo.StaffManagement.Domain.Tests.Servicies
{
    public class DepartmentServiceTests
    {
        private readonly IDepartmentService _service;
        private readonly IDepartmentRepositiry _fakeRepositiry;

        public DepartmentServiceTests()
        {
            _fakeRepositiry = A.Fake<IDepartmentRepositiry>();
            _service = new DepartmentService(_fakeRepositiry);
        }

        [Fact]
        public void Upsert_NewCategory_MustCreateNew()
        {
            DepartmentDto department = new DepartmentDto() { DepartmentId = 0 };

            _service.Upsert(department);

            A.CallTo(() => _fakeRepositiry.Create(department)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Upsert_OldCategory_MustUpdate()
        {
            DepartmentDto department = new DepartmentDto() { DepartmentId = 1 };

            _service.Upsert(department);

            A.CallTo(() => _fakeRepositiry.Update(department)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetById_DeartmentId_DepertmentWithIdTwo()
        {
            //Arrange
            int depId = 2;
            DepartmentDto department = new DepartmentDto() { DepartmentId = depId };
            A.CallTo(() => _fakeRepositiry.GetById<DepartmentDto>(depId)).Returns(department);
            //Act
            var departmentDto = _service.GetById(depId);
            //Assert
            Assert.Equal(depId, departmentDto.DepartmentId);
        }
    }
}
