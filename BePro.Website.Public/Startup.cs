using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BePro.Website.Public.Startup))]
namespace BePro.Website.Public
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
