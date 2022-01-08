using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flick_Sell.Startup))]
namespace Flick_Sell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
