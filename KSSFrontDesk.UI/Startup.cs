using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KSSFrontDesk.UI.Startup))]
namespace KSSFrontDesk.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
