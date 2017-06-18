using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneiricGigs.Startup))]
namespace OneiricGigs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
