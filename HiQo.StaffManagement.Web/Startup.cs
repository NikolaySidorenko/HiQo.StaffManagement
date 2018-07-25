using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiQo.StaffManagement.Web.Startup))]
namespace HiQo.StaffManagement.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
