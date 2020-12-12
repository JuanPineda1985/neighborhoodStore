using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(neighborhoodStore.Startup))]
namespace neighborhoodStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
