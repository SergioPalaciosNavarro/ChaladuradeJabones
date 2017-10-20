using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChaladuradeJabones.Startup))]
namespace ChaladuradeJabones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
