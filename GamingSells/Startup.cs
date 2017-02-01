using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamingSells.Startup))]
namespace GamingSells
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
