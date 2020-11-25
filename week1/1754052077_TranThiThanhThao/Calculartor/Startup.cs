using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calculartor.Startup))]
namespace Calculartor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
