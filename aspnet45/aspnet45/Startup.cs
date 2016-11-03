using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet45.Startup))]
namespace aspnet45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
