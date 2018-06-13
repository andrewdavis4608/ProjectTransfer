using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TFVC_GIT_Test.Startup))]
namespace TFVC_GIT_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
