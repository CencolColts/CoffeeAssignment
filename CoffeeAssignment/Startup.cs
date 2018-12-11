using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoffeeAssignment.Startup))]
namespace CoffeeAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
