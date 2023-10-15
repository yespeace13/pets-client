using ModelLibrary.View;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace PetsClient.Services
{
    public class APIServiceConnection<TList, TEdit, TOne> : IPetsAPIClientService<TList, TEdit, TOne>
    {
        private RestClient _сlient;
        public APIServiceConnection()
        {
            _сlient = new RestClient(ConnectionConfig.URL,
                configureSerialization: s => s.UseNewtonsoftJson());
        }

        public void Delete(string resources, int id)
        {
            var request = new RestRequest(resources + $"/{id}", Method.Delete);
            //request.AddHeader("")
            _сlient.Execute(request);
        }

        public PageSettings<TList> Get(string resources, PageSettingsView pageSettings)
        {
            var request = new RestRequest(resources, Method.Get);
            request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

            request.AddParameter("Page", pageSettings.Page);
            request.AddParameter("Pages", pageSettings.Pages);
            
            var filters = pageSettings.Filter.Columns
                .Select(c => $"{c}:{Uri.EscapeDataString(pageSettings.Filter[c])}")
                .ToArray();
            var filter = String.Join(";", filters);

            request.AddParameter("Filter", filter);
            request.AddParameter("SortField", pageSettings.Sort.Column);
            request.AddParameter("SortType", pageSettings.Sort.Direction);

            var execute = _сlient.ExecuteGet<PageSettings<TList>>(request);
            if (execute.IsSuccessful)
            {
                return execute.Data;
            }
            throw new Exception("Ошибка запроса public PageSettings<TList> Get(string resources, PageSettingsView pageSettings)");
        }

        public List<T> Get<T>(string resources)
        {
            var request = new RestRequest(resources);
            var execute = _сlient.ExecuteGet<List<T>>(request);
            if (execute.IsSuccessful)
            {
                return execute.Data;
            }
            throw new Exception("Ошибка запроса public List<T> Get<T>(string resources)");

        }
        public TOne Get(string resources, int id)
        {
            var request = new RestRequest(resources + $"/{id}");
            var execute = _сlient.ExecuteGet<TOne>(request);
            if (execute.IsSuccessful)
            {
                return execute.Data;
            }
            throw new Exception("Ошибка запроса public T Get(string resources, int id)");
        }

        public byte[] GetFile(string resources, FilterSetting filters)
        {
            var queryFilters = filters.Columns
                .Select(c => $"{c}:{Uri.EscapeDataString(filters[c])}")
                .ToArray();
            var query = String.Join(";", filters);
            return _сlient.DownloadData(new RestRequest(resources, Method.Get));
        }

        public void Post(string resources, TEdit view)
        {
            var request = new RestRequest(resources);
            if (view == null) throw new ArgumentNullException("Не передан параметр view");
            request.AddBody(view);
            _сlient.Post(request);
        }

        public void Put(string resources, int id, TEdit view)
        {
            var request = new RestRequest(resources + $"/{id}");
            if (view == null) throw new ArgumentNullException("Не передан параметр view");
            request.AddBody(view);
            _сlient.Put(request);
        }
    }
}
