using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ngMap.Startup))]
namespace ngMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
