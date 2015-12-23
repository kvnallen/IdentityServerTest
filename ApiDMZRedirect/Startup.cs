using Owin;
using System.Web.Http;

namespace ApiDMZRedirect
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            
            app.UseWebApi(config);

        }
    }
}
