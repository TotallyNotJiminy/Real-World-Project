using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(F.app.Startup))]
namespace F.app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
