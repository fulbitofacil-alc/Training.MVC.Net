using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Course.Views.Startup))]
namespace MVC5Course.Views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
