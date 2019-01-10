using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionReservas.UI.Startup))]
namespace GestionReservas.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
