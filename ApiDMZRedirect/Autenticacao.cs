using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDMZRedirect
{
    public class Autenticacao
    {

       public string  ClientId { get; set; }
       public string ClientSecret { get; set; }
        public string Usuario { get; set; }
       public string Senha { get; set; }
        public string Escopo { get; set; }
    }
}
