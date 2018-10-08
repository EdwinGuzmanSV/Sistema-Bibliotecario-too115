using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionAdministradores.Startup))]
namespace GestionAdministradores
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
