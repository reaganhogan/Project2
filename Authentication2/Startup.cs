using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authentication2.Startup))]
namespace Authentication2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
