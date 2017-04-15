using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSSMediaQueryTest.Startup))]
namespace CSSMediaQueryTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
