using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace HiQo.StaffManagement.Configuration.CastleWindsor
{
    public class IoCContainer
    {
        private static IWindsorContainer _container;

        public static void Setup(string assemblyName)
        {
            _container = new WindsorContainer();
            
            //var instaler = FromAssembly.Named(assembly.FullName);
            //_container =_container.Install(instaler);

            ControllersInstaller installer=new ControllersInstaller(assemblyName);
            installer.Install(_container,null);

            DependencyResolverInstaller resolver=new DependencyResolverInstaller();
            resolver.Install(_container,null);

            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}
