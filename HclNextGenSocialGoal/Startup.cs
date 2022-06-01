using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HclNextGenSocialGoal.Startup))]
namespace HclNextGenSocialGoal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
