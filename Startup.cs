using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EADP.Startup))]
namespace EADP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
