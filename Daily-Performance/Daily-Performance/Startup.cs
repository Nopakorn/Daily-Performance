using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Daily_Performance.Startup))]
namespace Daily_Performance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
