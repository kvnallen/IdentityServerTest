using System.Collections.Generic;
using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Services.InMemory;
using Microsoft.Owin;
using Owin;
using SSO.ConsoleApp;
using SSO.ConsoleApp.Models;

[assembly: OwinStartup(typeof(Startup))]

namespace SSO.ConsoleApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new IdentityServerOptions
            {
                Factory = new IdentityServerServiceFactory()
                            .UseInMemoryClients(Clients.Get())
                            .UseInMemoryScopes(Scopes.Get())
                            .UseInMemoryUsers(Users.Get())
            };

           /* var options = new IdentityServerOptions
            {
                Factory = Factory.
            };*/

            app.UseIdentityServer(options);
        }
    }
}
