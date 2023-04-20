using System;
using System.Threading.Tasks;
using Instagames.WebApi.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(Instagames.WebApi.Startup))]

namespace Instagames.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            OAuthAuthorizationServerOptions option = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new ApplicationOAuthProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(365),
                AllowInsecureHttp = true
            };

            app.UseOAuthAuthorizationServer(option);
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions());

            
        }

    }
}
