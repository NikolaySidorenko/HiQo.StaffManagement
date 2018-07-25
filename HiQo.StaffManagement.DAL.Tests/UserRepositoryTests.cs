using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.Configuration.AutoMapper;
using HiQo.StaffManagement.Configuration.AutoMapper.Profiles;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.EntitiesDTO;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace HiQo.StaffManagement.DAL.Tests
{

    public class UserRepositoryTests
    {
        [Fact]
        public void TestMethod1()
        {
           AutomapperConfiguration.ConfigureAutomapper();

           

        }

        
    }
}
