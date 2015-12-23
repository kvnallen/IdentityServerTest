using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSO.Console2.Client;
using System.Net.Http;
using System.Net;
using System.IO;
using IdentityModel.Client;
using Newtonsoft.Json;
using System.Diagnostics;

namespace SSO.Console2
{
    class Program
    {

        private static string  AccessToken = "";


        static void Main(string[] args)
        {
            Console.WriteLine("Access_Token:" + AccessToken);

            ObterToken();

            Console.WriteLine("Access_Token: " + AccessToken);
        }


        public static async void ObterToken()
        {
           
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("clientId", "carbon"),
                new KeyValuePair<string, string>("clientSecret", "21B5F798-BE55-42BC-8AA8-0025B903DC3B"),
                new KeyValuePair<string, string>("usuario", "bob"),
                new KeyValuePair<string, string>("senha", "secret"),
                new KeyValuePair<string, string>("escopo", "api1")
            };


            var content2 = new FormUrlEncodedContent(pairs);


            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:52889");
                
                var httpResponse =  httpClient.PostAsync("/acesso", content2).Result;

                var resultado = httpResponse.IsSuccessStatusCode;
                
                if (httpResponse.Content != null)
                {
                    var conteudoDeAcesso =  await httpResponse.Content.ReadAsStringAsync();
                    dynamic obj = JsonConvert.DeserializeObject<dynamic>(conteudoDeAcesso);
                    AccessToken = obj.access_token.ToString();
                   

                }
            }
          

        }
    }
}
