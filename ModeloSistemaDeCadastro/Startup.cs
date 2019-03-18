using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModeloSistemaDeCadastro.Startup))]
namespace ModeloSistemaDeCadastro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
