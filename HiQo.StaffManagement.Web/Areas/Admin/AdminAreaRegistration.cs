using System.Reflection;
using System.Web.Mvc;

namespace HiQo.StaffManagement.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            var name = Assembly.GetExecutingAssembly().GetName().Name + ".Areas.Admin.Controllers";
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces:new []{name}

            );
        }
    }
}