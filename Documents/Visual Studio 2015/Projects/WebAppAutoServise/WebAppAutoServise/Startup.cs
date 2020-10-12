using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAutoServise.Startup))]
namespace WebAppAutoServise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
