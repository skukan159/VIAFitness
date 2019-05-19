using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIAFitness.Startup))]
namespace VIAFitness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
