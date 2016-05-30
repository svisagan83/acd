using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(academica.Startup))]
namespace academica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
