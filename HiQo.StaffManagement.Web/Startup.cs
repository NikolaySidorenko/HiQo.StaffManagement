using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(HiQo.StaffManagement.Web.Startup))]

namespace HiQo.StaffManagement.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });

           // app.CreatePerOwinContext(() => DependencyResolver.Current.GetService<UserManager<UserDto, int>>());
        }
    }
}