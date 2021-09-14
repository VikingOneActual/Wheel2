using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wheel2.Startup))]
namespace Wheel2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
