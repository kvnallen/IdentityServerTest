using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSO.Core
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Enabled { get; private set; }
    }
}
