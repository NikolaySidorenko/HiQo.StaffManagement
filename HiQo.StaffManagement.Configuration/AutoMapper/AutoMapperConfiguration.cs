using System;
using System.Linq;
using AutoMapper;

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
