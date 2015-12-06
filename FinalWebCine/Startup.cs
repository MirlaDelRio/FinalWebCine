using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalWebCine.Startup))]
namespace FinalWebCine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
