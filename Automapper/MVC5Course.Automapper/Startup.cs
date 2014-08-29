using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Course.Automapper.Startup))]
namespace MVC5Course.Automapper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
