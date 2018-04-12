using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BroSecretary.Startup))]
namespace BroSecretary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
