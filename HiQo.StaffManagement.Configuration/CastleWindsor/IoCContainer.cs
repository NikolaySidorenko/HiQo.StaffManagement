using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void Setup()
        {
            _container = new WindsorContainer();
            var s = FromAssembly.Named("HiQo.StaffManagement.Configuration");
            _container =_container.Install(s);

            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}
