using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHub_Demo.Startup))]
namespace GitHub_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
