using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FaceBooWEB_3raye2.Startup))]
namespace FaceBooWEB_3raye2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
