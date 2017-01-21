using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspnetLab2.Startup))]
namespace AspnetLab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
