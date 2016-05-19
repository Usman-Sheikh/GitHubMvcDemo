using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubDemo.Startup))]
namespace GitHubDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
