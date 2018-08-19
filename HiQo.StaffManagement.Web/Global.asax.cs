using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FluentValidation.Mvc;
using HiQo.StaffManagement.Configuration.AutoMapper;
using HiQo.StaffManagement.Configuration.CastleWindsor;

namespace HiQo.StaffManagement.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterCssBundles(BundleTable.Bundles);
            BundleConfig.RegisterJsBundles(BundleTable.Bundles);

             AutomapperConfiguration.ConfigureAutomapper();

            var assembly = Assembly.GetExecutingAssembly();
            IoCContainer.Setup(assembly.GetName().Name);
            
        }

    }
}
