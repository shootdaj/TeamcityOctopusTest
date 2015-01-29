using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamcityOctopusTest.Startup))]
namespace TeamcityOctopusTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
