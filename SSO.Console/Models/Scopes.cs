using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace SSO.ConsoleApp.Models
{
    static class Scopes
    {
        public static List<Scope> Get()
        {
            return new List<Scope>
        {
            new Scope
            {
                Name = "api1"
            }

        };
        }
    }
}