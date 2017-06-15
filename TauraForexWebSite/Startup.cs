using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TauraForexWebSite.Startup))]
namespace TauraForexWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
