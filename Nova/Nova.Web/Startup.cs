using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nova.Web.Startup))]
namespace Nova.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
