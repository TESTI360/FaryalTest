using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(employeemanagement.Startup))]
namespace employeemanagement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
