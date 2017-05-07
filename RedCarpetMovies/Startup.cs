using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedCarpetMovies.Startup))]
namespace RedCarpetMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
