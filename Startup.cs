using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_31181020918_LeGiaPhuc.Startup))]
namespace _31181020918_LeGiaPhuc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
