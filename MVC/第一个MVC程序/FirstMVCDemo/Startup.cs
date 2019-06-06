using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstMVCDemo.Startup))]
namespace FirstMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
