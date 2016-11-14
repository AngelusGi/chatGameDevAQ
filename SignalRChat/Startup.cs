using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(GameDevAQ.Startup))]

namespace GameDevAQ
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}