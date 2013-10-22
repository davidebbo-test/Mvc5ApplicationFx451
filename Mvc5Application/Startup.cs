using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5Application.Startup))]
namespace Mvc5Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
