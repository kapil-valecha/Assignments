using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Institute.Startup))]
namespace Institute
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
