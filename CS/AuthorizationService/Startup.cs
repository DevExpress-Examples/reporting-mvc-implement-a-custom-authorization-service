using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthorizationService.Startup))]
namespace AuthorizationService {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
