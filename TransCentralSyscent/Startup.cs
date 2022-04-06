using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TransCentralSyscent.Startup))]
namespace TransCentralSyscent
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
