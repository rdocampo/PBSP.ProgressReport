using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PBSP.ProgressReport.Startup))]
namespace PBSP.ProgressReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
