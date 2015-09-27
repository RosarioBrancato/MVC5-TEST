using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Donations.Startup))]
namespace Donations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
