using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace PetsClient.Services
{
    public class AuthorizationService
    {
        public static bool Authorization(string login)
        {
            var request = new RestRequest(ConnectionConfig.URL + $"login/{login}");
            var response = new RestClient().Execute(request);
            if (response.IsSuccessful)
            {
                dynamic resp = JObject.Parse(response.Content);
                ConnectionConfig.Token = resp.access_token;
                return true;
            }
            return false;
        }
    }
}
