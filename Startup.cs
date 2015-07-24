using Microsoft.Owin;
using System.Web.Http.Owin;
using global::Owin;

[assembly: OwinStartupAttribute(typeof(ePro.Startup))]
namespace ePro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
