using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMSFinal.Startup))]
namespace CMSFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
