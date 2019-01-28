using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnTheKnee.Startup))]
namespace OnTheKnee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
