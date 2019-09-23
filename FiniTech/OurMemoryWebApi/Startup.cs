using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OurMemoryWebApi.Startup))]

namespace OurMemoryWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
