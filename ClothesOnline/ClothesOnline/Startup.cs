using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothesOnline.Startup))]
namespace ClothesOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
