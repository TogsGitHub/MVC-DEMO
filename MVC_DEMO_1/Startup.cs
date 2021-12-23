using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_DEMO_1.Startup))]
namespace MVC_DEMO_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
