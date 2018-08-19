using System.Web.Mvc;
using System.Web.Routing;

namespace HiQo.StaffManagement.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var name = typeof(RouteConfig).Namespace + ".Controllers";
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { name }    
            );

                
        }
    }
}
