using System.Diagnostics;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using SSO.Core;

namespace SSO.ConsoleApp.EF
{
    public class CustomUserService : IUserService
    {


        public CustomUserService()
        {

        }

        public Task PreAuthenticateAsync(PreAuthenticationContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task AuthenticateLocalAsync(LocalAuthenticationContext context)
        {
            if (context.UserName == "Kevin")
            {
                Debug.WriteLine("LOL");
            }

            throw new System.NotImplementedException();
        }

        public Task AuthenticateExternalAsync(ExternalAuthenticationContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task PostAuthenticateAsync(PostAuthenticationContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task SignOutAsync(SignOutContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task IsActiveAsync(IsActiveContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}