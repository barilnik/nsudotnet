using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Afisha.Startup))]
namespace Afisha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
