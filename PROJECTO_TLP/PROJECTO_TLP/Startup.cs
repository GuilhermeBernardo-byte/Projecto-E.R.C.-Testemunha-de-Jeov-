using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PROJECTO_TLP.Startup))]
namespace PROJECTO_TLP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
