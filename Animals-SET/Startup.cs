using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Animals_SET.Startup))]
namespace Animals_SET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
