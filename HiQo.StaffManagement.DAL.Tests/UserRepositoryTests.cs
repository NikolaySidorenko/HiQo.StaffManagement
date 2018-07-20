using AutoMapper;
using HiQo.StaffManagement.Configuration.AutoMapper.Profiles;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace HiQo.StaffManagement.DAL.Tests
{

    public class UserRepositoryTests
    {
        [Fact]
        public void TestMethod1()
        {
            ConfigureAutomapper();

            UserDTO user;
            using (var dbContext = new CompanyContext())
            {
                UserRepository userRepository = new UserRepository(dbContext);
                user = userRepository.GetById<User,UserDTO>(3);
            }

            Assert.AreEqual(3,user.UserId);
        }

        private static void ConfigureAutomapper()
        {
            Mapper.Initialize(GetConfiguration);
        }

        private static void GetConfiguration(IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile(typeof(UserProfiler));
        }
    }
}
