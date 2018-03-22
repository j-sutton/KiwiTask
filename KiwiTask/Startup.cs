using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiwiTask.Startup))]
namespace KiwiTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
