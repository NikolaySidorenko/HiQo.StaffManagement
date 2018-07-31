using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace HiQo.StaffManagement.Configuration.CastleWindsor
{
    public class ControllersInstaller:IWindsorInstaller
    {
        private readonly string _assemblyName;

        public ControllersInstaller()
        {
            
        }

        public ControllersInstaller(string assemblyName)
        {
            _assemblyName = assemblyName;
        }


        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(AllTypes.FromAssemblyNamed("HiQo.StaffManagement.Web")
            //    .Pick().If(t => t.Name.EndsWith("Controller"))
            //    .Configure(configurer => configurer.Named(configurer.Implementation.Name))
            //    .LifestylePerWebRequest());

            container.Register(Classes.FromAssemblyNamed(_assemblyName)
                .BasedOn<IController>()
                .LifestylePerWebRequest()
                .Configure(x => x.Named(x.Implementation.FullName)));
        }
    }
}
