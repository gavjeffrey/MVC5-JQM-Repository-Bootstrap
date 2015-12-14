using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Bootstrap.Web.Startup))]
namespace MVC5Bootstrap.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
