using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MOC.Startup))]
namespace MOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
