using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GUI_FrontEnd.Startup))]
namespace GUI_FrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
