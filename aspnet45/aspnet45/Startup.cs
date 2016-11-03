using Microsoft.Owin;
using NWebsec.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet45.Startup))]
namespace aspnet45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.UseHsts(options => options.MaxAge(minutes: 2).IncludeSubdomains());
            //app.UseHsts(options => options.MaxAge(days:365).IncludeSubdomains().Preload());
            //app.UseHsts(options => options.MaxAge(days:365).UpgradeInsecureRequests());


            //app.UseHpkp(options => options
            //    .Sha256Pins(
            //        "Base64 encodedSHA-256 hash",
            //        "Base64 encoded SHA-256 hash of backup")
            //    .MaxAge(days: 18 * 7)
            //    .IncludeSubdomains());

            app.UseCsp(x => x.UpgradeInsecureRequests());
        }
    }
}
