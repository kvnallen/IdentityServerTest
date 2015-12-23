using System.Collections.Generic;
using System.Linq;
using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using IdentityServer3.EntityFramework;
using SSO.ConsoleApp.EF;
using SSO.ConsoleApp.Models;

namespace SSO.ConsoleApp.Config
{
    public class Factory
    {
        public static IdentityServerServiceFactory Configure(string connectionString)
        {
            var options = new EntityFrameworkServiceOptions
            {
                ConnectionString = connectionString
            };

            ConfigureClients(Clients.Get(), options);
            ConfigureScopes(Scopes.Get(), options);

            var factory = new IdentityServerServiceFactory();

            factory.RegisterConfigurationServices(options);
            factory.RegisterOperationalServices(options);

            factory.Register(new Registration<MeuContext>());
            factory.UserService = new Registration<IUserService, CustomUserService>();
        }

        private static void ConfigureClients(IEnumerable<Client> clients, EntityFrameworkServiceOptions options)
        {
            using (var db = new ClientConfigurationDbContext(options.ConnectionString, options.Schema))
            {
                if (db.Clients.Any()) return;

                foreach (var e in clients.Select(c => c.ToEntity()))
                    db.Clients.Add(e);

                db.SaveChanges();
            }
        }

        private static void ConfigureScopes(IEnumerable<Scope> scopes, EntityFrameworkServiceOptions options)
        {
            using (var db = new ScopeConfigurationDbContext(options.ConnectionString, options.Schema))
            {
                if (db.Scopes.Any()) return;

                foreach (var e in scopes.Select(s => s.ToEntity()))
                    db.Scopes.Add(e);

                db.SaveChanges();
            }
        }
    }
}