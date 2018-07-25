using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HiQo.StaffManagement.Configuration.AutoMapper.Profiles;

namespace HiQo.StaffManagement.Configuration.AutoMapper
{
    public static class AutomapperConfiguration
    {

        public static void ConfigureAutomapper()
        {
            Mapper.Initialize(GetConfiguration);
        }

        private static void GetConfiguration(IMapperConfigurationExpression configuration)
        {
            var profiles = typeof(AutomapperConfiguration).Assembly.GetTypes().Where(x => typeof(Profile).IsAssignableFrom(x));

            foreach (var profile in profiles)
            {
                configuration.AddProfile(Activator.CreateInstance(profile) as Profile);
            }
        }
    }
}
