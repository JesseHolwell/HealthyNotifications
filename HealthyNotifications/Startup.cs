using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyNotifications.Startup))]
namespace HealthyNotifications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
