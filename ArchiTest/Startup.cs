using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArchiTest.Startup))]
namespace ArchiTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
