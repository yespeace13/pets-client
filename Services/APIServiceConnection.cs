using ModelLibrary.View;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace IS_5.Services
{
    public class APIServiceConnection<T> : IPetsAPIClientService<T>
    {
        private static string URL = "https://localhost:7279/";
        private RestClient _restClient;
        public APIServiceConnection() 
        {
            _restClient = new RestClient(URL,
                configureSerialization: s => s.UseNewtonsoftJson());
        }

        public void Delete(string resources, int id)
        {
            var request = new RestRequest(resources);
            request.AddHeader<int>("Id", id);
            _restClient.Delete(request);
        }

        public PageSettings<T> Get(string resources, PageSettingsView pageSettings)
        {
            var request = new RestRequest(resources);
            request.AddHeader<int>("Page", pageSettings.Page);
            request.AddHeader<int>("Pages", pageSettings.Pages);
            var filters = pageSettings.Filter.Columns.Select(c => $"{c}:{Uri.EscapeDataString(pageSettings.Filter[c])}").ToArray();
            var filter = String.Join(";", filters);
            request.AddHeader("Filter", filter);
            request.AddHeader("SortField", pageSettings.Sort.Column);
            request.AddHeader<int>("SortType", pageSettings.Sort.Direction);
            return _restClient.Get<PageSettings<T>>(request);
        }

        public T Get(string resources, int id)
        {
            var request = new RestRequest(resources);
            request.AddHeader<int>("Id", id);
            return _restClient.Get<T>(request);
        }

        public void Post(string resources, T view)
        {
            var request = new RestRequest(resources);
            request.AddBody(view);
            _restClient.Post(request);
        }

        public void Put(string resources, int id, T view)
        {
            throw new NotImplementedException();
        }
    }
}
