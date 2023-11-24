using ModelLibrary.Model.Authentication;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace PetsClient.Services
{
    public class AuthorizationService
    {
        private static RestClient _сlient;

        static AuthorizationService()
        {
            _сlient = new RestClient(ConnectionConfig.URL,
                    configureSerialization: s => s.UseNewtonsoftJson());
        }
        public static bool IsAuthentication(string login, string password)
        {
            var request = new RestRequest(ConnectionConfig.URL + $"login");
            request.AddParameter("login", login);
            request.AddParameter("password", password);
            var response = new RestClient().Execute(request);
            if (response.IsSuccessful)
            {
                dynamic resp = JObject.Parse(response.Content);
                ConnectionConfig.Token = resp.access_token;
                return true;
            }
            return false;
        }

        public static List<UserPossibilities> GetPossibilities()
        {
            var request = new RestRequest("authorization", Method.Get);
            request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

            var execute = _сlient.ExecuteGet<List<UserPossibilities>>(request);
            if (execute.IsSuccessful)
                return execute.Data;
            throw new Exception(execute.ErrorMessage);
        }
    }
}
