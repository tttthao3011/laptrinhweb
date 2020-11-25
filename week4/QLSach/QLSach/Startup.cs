using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLSach.Startup))]
namespace QLSach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
