using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(smarthomeautomation.Startup))]
namespace smarthomeautomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
