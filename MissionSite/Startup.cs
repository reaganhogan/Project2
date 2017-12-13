using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MissionSite.Startup))]
namespace MissionSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
