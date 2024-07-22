using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSIDAlarmSystem.Startup))]
namespace BSIDAlarmSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
