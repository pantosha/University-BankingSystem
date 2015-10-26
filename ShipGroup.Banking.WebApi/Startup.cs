using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ShipGroup.Banking.WebApi.Startup))]

namespace ShipGroup.Banking.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}