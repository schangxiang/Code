using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04_Unity在MVC中引用.Startup))]
namespace _04_Unity在MVC中引用
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
