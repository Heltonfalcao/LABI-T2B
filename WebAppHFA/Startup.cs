using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppHFA.Startup))]
namespace WebAppHFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
