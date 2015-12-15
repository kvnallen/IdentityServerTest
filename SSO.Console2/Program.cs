using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSO.Console2.Client;

namespace SSO.Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenResponse = TokenHelper.GetClientToken();
            TokenHelper.CallApi(tokenResponse);
            var result = TokenHelper.GetUserToken();
            TokenHelper.CallApi(result);
        }
    }
}
