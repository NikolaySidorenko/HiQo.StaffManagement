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

    public class UserServiceTests
    {
        private readonly IUserService _service;
        private readonly IUserRepositiry _fakeRepositiry;

        public UserServiceTests()
        {
            _fakeRepositiry = A.Fake<IUserRepositiry>();
            _service = new UserService(_fakeRepositiry);
        }

        [Fact]
        public void GetById_UserId_UserWithIdTwo()
        {
            //Arrange
            int userId = 2;
            UserDto user = new UserDto { UserId = userId};
            A.CallTo(() => _fakeRepositiry.GetById<UserDto>(userId)).Returns(user);
            //Act
            var userDto= _service.GetById(userId);
            //Assert
            Assert.Equal(userId,userDto.UserId);
        }

        [Fact]
        public void GetAll_Nothing_TwoUsers()
        {
            
            List<UserDto> users = new List<UserDto>{new UserDto {UserId = 1}, new UserDto {UserId = 2}};
            var idArray = new[] {1, 2};
            A.CallTo(() => _fakeRepositiry.GetAll<UserDto>()).Returns(users);

            var usersDto = _service.GetAll() as List<UserDto>;

            Assert.Equal(idArray.Length, usersDto.Count());

            for (int i = 0; i < users.Count(); i++)
            {
                Assert.Equal(idArray[i],usersDto[i].UserId);
            }
        }

        [Fact]
        public void Update_UserDto_MustHappened()
        {
            //Arrange
            UserDto userDto=new UserDto(){UserId = 1};
            //Act
            _service.Update(userDto);
            //Assert
            A.CallTo(() => _fakeRepositiry.Update(userDto)).MustHaveHappenedOnceExactly();
            A.CallTo(() => _fakeRepositiry.SaveChanges()).MustHaveHappenedOnceExactly();
        }
    }
}
