using ModelLibrary.View;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace PetsClient.Services;
public class APIServiceOne
{
    private static RestClient _сlient;

    static APIServiceOne()
    {
        _сlient = new RestClient(ConnectionConfig.URL,
                configureSerialization: s => s.UseNewtonsoftJson());
    }
    //TODO костыль костыльный обмазанный костылем
    // Получение записей, где Page
    public static List<T> GetAllFromPage<T>(string resources)
    {
        var pageSettings = new PageSettingsView(1, 500, null, null);
        var request = new RestRequest(resources, Method.Get);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        request.AddParameter("Page", pageSettings.Page);
        request.AddParameter("Pages", pageSettings.Pages);

        var execute = _сlient.ExecuteGet<PageSettings<T>>(request);
        if (execute.IsSuccessful)
            return execute.Data.Items.ToList();
        throw new Exception(execute.ErrorMessage);
    }

    // получение всех записей, где нет Page
    public static List<T> GetAll<T>(string resources)
    {
        var request = new RestRequest(resources, Method.Get);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        var execute = _сlient.ExecuteGet<List<T>>(request);
        if (execute.IsSuccessful)
            return execute.Data;
        throw new Exception(execute.ErrorMessage);
    }

    public static T GetOne<T>(string resources, int id)
    {
        var request = new RestRequest(resources + "/id");
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);
        var execute = _сlient.ExecuteGet<T>(request);
        if (execute.IsSuccessful)
        {
            return execute.Data;
        }
        throw new Exception(execute.ErrorMessage);
    }

    public void Post<T>(string resources, T view)
    {
        var request = new RestRequest(resources);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        if (view == null) throw new ArgumentNullException("Не передан параметр view");
        request.AddBody(view);
        _сlient.Post(request);
    }

    public void Put<T>(string resources, int id, T view)
    {
        var request = new RestRequest(resources + $"/{id}");
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        if (view == null) throw new ArgumentNullException("Не передан параметр view");
        request.AddBody(view);
        _сlient.Put(request);
    }
}

