﻿using ModelLibrary.Model.Etc;
using ModelLibrary.View;
using PetsClient.Properties;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace PetsClient.Services;
public class APIServiceOne
{
    private static readonly RestClient _сlient;

    static APIServiceOne()
    {
        _сlient = new RestClient(ConnectionConfig.URL,
                configureSerialization: s => s.UseNewtonsoftJson());
    }
    //TODO костыль костыльный обмазанный костылем
    // Получение записей, где Page
    public static List<T>? GetAllFromPage<T>(string resources)
    {
        var pageSettings = new PageSettingsView(1, 500, null, null);
        var request = new RestRequest(resources, Method.Get);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        request.AddParameter("Page", pageSettings.Page);
        request.AddParameter("Pages", pageSettings.Pages);

        var execute = _сlient.ExecuteGet<PageSettings<T>>(request);
        if (execute.IsSuccessful)
            return execute.Data?.Items.ToList();
        if (execute.StatusCode == System.Net.HttpStatusCode.Forbidden)
            MessageBox.Show("У вас нет прав на: " + resources);
        throw new Exception(execute.ErrorMessage);
    }

    // получение всех записей, где нет Page
    public static List<T>? GetAll<T>(string resources)
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

    public static byte[]? GetFile(string resource)
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

    internal static List<FileBaseView>? GetFiles(string resource, int id)
    {
        var request = new RestRequest(resource + "/" + id, Method.Get);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        var execute = _сlient.ExecuteGet<List<FileBaseView>>(request);
        if (execute.IsSuccessful)
            return execute.Data;
        throw new Exception(execute.ErrorMessage);
    }

    public static T? Get<T>(string resource)
    {
        var request = new RestRequest(resource, Method.Get);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);

        var execute = _сlient.ExecuteGet<T>(request);
        if (execute.IsSuccessful)
            return execute.Data;
        throw new Exception(execute.ErrorMessage);
    }

    public static string? Post(string resource)
    {
        var request = new RestRequest(resource, Method.Post);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);
        var response = _сlient.ExecutePost(request);
        if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            return "У вас нет прав";
        else
            return response.Content;
    }

    internal static string? CheckReports(string resource)
    {
        var request = new RestRequest(resource, Method.Post);
        request.AddHeader("Authorization", "Bearer " + ConnectionConfig.Token);
        var response = _сlient.ExecuteGet(request);
        if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            return null;
        return response.Content?.Replace("\"", "");

    }
}

