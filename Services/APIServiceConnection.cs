using ModelLibrary.View;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;

namespace IS_5.Services
{
    public class APIServiceConnection<TList, TEdit, TOne> : IPetsAPIClientService<TList, TEdit, TOne>
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
            var request = new RestRequest(resources + $"/{id}", Method.Delete);
            _restClient.Execute(request);
        }

        public PageSettings<TList> Get(string resources, PageSettingsView pageSettings)
        {
            var request = new RestRequest(resources);
            request.AddHeader<int>("Page", pageSettings.Page);
            request.AddHeader<int>("Pages", pageSettings.Pages);
            var filters = pageSettings.Filter.Columns.Select(c => $"{c}:{Uri.EscapeDataString(pageSettings.Filter[c])}").ToArray();
            var filter = String.Join(";", filters);
            request.AddHeader("Filter", filter);
            request.AddHeader("SortField", pageSettings.Sort.Column);
            request.AddHeader<int>("SortType", pageSettings.Sort.Direction);
            return _restClient.Get<PageSettings<TList>>(request);
        }

        public List<T> Get<T>(string resources)
        {
            var request = new RestRequest(resources);
            var execute = _restClient.ExecuteGet<List<T>>(request);
            if (execute.IsSuccessful)
            {
                return execute.Data;
            }
            throw new Exception("Ошибка запроса public List<T> Get<T>(string resources)");
            
        }
        public TOne Get(string resources, int id)
        {
            var request = new RestRequest(resources + $"/{id}");
            var execute = _restClient.ExecuteGet<TOne>(request);
            if (execute.IsSuccessful)
            {
                return execute.Data;
            }
            throw new Exception("Ошибка запроса public T Get(string resources, int id)");
        }

        public void Post(string resources, TEdit view)
        {
            var request = new RestRequest(resources);
            if (view == null) throw new ArgumentNullException("Не передан параметр view");
            request.AddBody(view);
            _restClient.Post(request);
        }

        public void Put(string resources, int id, TEdit view)
        {
            var request = new RestRequest(resources + $"/{id}");
            if (view == null) throw new ArgumentNullException("Не передан параметр view");
            request.AddBody(view);
            _restClient.Put(request);
        }
    }
}
