using ModelLibrary.Model.Etc;
using ModelLibrary.View;
using PetsClient.Properties;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System.Resources;

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

    public static void CreateReport(string resource, DateOnly from, DateOnly to)
    {
        var request = new RestRequest(resource, Method.Post);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);
        request.AddQueryParameter("from", from.ToString());
        request.AddQueryParameter("to", to.ToString());

        _сlient.Post(request);
    }

    public static byte[] GetFile(string resource)
    {
        var data = _сlient.DownloadData(new RestRequest(resource, Method.Get));
        return data;
    }

    internal static void UploadFile(string resource, byte[] file, int parentId)
    {
        var request = new RestRequest(resource + "/" + parentId, Method.Post);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);
        request.AddFile("file", file, "file");
        _сlient.Post(request);
    }

    internal static void DeleteFile(string resource, int id)
    {
        var request = new RestRequest(resource + "/" + id);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);
        _сlient.Delete(request);
    }

    internal static List<FileBaseView> GetFiles(string resource, int id)
    {
        var request = new RestRequest(resource + "/" + id, Method.Get);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        var execute = _сlient.ExecuteGet<List<FileBaseView>>(request);
        if (execute.IsSuccessful)
            return execute.Data;
        throw new Exception(execute.ErrorMessage);
    }
}

