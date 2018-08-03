using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service;
using HiQo.StaffManagement.Domain.Service.Interfaces;
using Xunit;


namespace HiQo.StaffManagement.Domain.Tests.Servicies
{
    public class UserUpsertServiceTest
    {
        private IUpsertUserService _service;
        private readonly IUserRepositiry _userRepositiry;
        private readonly ICategoryService _categoryService;
        private readonly IPositionService _positionService;
        private readonly ISharedService _sharedService;

        public UserUpsertServiceTest()
        {
            _userRepositiry = A.Fake<IUserRepositiry>();
            _categoryService = A.Fake<ICategoryService>();
            _positionService = A.Fake<IPositionService>();
            _sharedService = A.Fake<ISharedService>();

            _service=new UpsertUserService(_userRepositiry,_categoryService,_positionService,_sharedService);

        }

        [Fact]
        public void GetById_()
        {
            int userId = 1;
            var user=new UserDto(){UserId = userId};
            A.CallTo(() => _userRepositiry.GetById<UserDto>(userId)).Returns(user);

            var userDto = _service.GetById(userId);

            Assert.Equal(userId,userDto.UserId);
        }

        [Fact]
        public void GetCategoriesByDepartmentId_DepartmentId_()
        {
            int depId = 1;
            List<CategoryDto> categoriesTest=new List<CategoryDto>(){new CategoryDto(){CategoryId = 1}};
            List<CategoryDto> categories = new List<CategoryDto>() { new CategoryDto() { CategoryId = 1 } };
            A.CallTo(() => _categoryService.GetByDepartmentId(depId)).Returns(categories);

            _service.GetCategoriesByDepartmentId(depId);

            Assert.Equal(categories.Count(),categoriesTest.Count);
            for (int i = 0; i < categories.Count(); i++)
            {
                Assert.Equal(categories[i].CategoryId,categoriesTest[i].CategoryId);
            }

        }

        [Fact]
        public void GetPositionsByCategoryId_()
        {
            int catId = 1;
            List<PositionDto> categoriesTest = new List<PositionDto>() { new PositionDto() { PositionId = 1 } };
            List<PositionDto> categories = new List<PositionDto>() { new PositionDto() { PositionId = 1 } };
            A.CallTo(() => _positionService.GetByCategoryId(catId)).Returns(categories);

            _service.GetCategoriesByDepartmentId(catId);

            Assert.Equal(categories.Count(), categoriesTest.Count);
            for (int i = 0; i < categories.Count(); i++)
            {
                Assert.Equal(categories[i].CategoryId, categoriesTest[i].CategoryId);
            }
        }

        [Fact]
        public void Create_UserDto_MustHappened()
        {
            var user=new UserDto{UserId = 1};

            _service.Create(user);

            A.CallTo(() => _userRepositiry.Create(user)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _userRepositiry.SaveChanges()).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Update_UserDto_MustHappened()
        {
            var user = new UserDto { UserId = 1 };

            _service.Create(user);

            A.CallTo(() => _userRepositiry.Update(user)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _userRepositiry.SaveChanges()).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetSharedInfo_Nothing_SharedInfo()
        {
            var info=new SharedInfoDto(){Categories = new []{new CategoryDto{CategoryId = 1}}};
            var infoTest = new SharedInfoDto() { Categories = new[] { new CategoryDto { CategoryId = 1 } } };
            A.CallTo(() => _sharedService.GetSharedInfo()).Returns(info);

            var result = _service.GetSharedInfo();

            Assert.Equal(infoTest.Categories.First().CategoryId,result.Categories.First().CategoryId);
 
        }
    }
}
