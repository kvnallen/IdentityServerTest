using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiDMZRedirect.Controllers
{
    [Route("acesso")]
    public class SSOAPIDmzController : ApiController
    {

        [HttpPost]
        public JObject Post([FromBody] Autenticacao body)
        {
            var client = new TokenClient(
                 "https://localhost:44333/connect/token",
                 body.ClientId,
                 body.ClientSecret);

            var result = client.RequestResourceOwnerPasswordAsync((string)body.Usuario, (string)body.Senha, (string)body.Escopo).Result;

            return result.Json;


        }

    }


}
