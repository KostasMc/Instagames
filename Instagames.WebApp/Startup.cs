using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Instagames.WebApp.Startup))]
namespace Instagames.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
