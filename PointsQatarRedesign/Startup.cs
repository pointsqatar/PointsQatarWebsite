using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PointsQatarRedesign.Startup))]
namespace PointsQatarRedesign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
