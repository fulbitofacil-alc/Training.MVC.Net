using Microsoft.Owin;
using Owin;

namespace SignalRChat
{
    [assembly: OwinStartup(typeof(SignalRChat.Startup))]
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}