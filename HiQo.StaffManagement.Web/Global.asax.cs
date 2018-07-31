using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HiQo.StaffManagement.Configuration.AutoMapper;
using HiQo.StaffManagement.Configuration.CastleWindsor;

namespace HiQo.StaffManagement.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutomapperConfiguration.ConfigureAutomapper();

            var assembly = Assembly.GetExecutingAssembly();
            IoCContainer.Setup(assembly.GetName().Name);
        }
    }
}
