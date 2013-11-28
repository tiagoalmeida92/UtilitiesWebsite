using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Utilities_UI.Startup))]
namespace Utilities_UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
