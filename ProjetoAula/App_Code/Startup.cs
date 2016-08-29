using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(localhost.Startup))]
namespace localhost
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
