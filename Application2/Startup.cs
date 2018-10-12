using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Application2.Startup))]
namespace Application2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
