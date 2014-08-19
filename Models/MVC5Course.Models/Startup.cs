using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Course.Models.Startup))]
namespace MVC5Course.Models
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
