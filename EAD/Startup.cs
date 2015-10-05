using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EAD.Startup))]
namespace EAD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
