using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Yanoac.ClientV2.Requests;

namespace Yanoac.ClientV2.Fragments;

public abstract class Fragment
{
    private readonly HttpClient _httpClient;
    private readonly OsuClientV2Settings _settings;
    
    protected Fragment(HttpClient httpClient, OsuClientV2Settings settings)
    {
        _httpClient = httpClient;
        _settings = settings;
    }

    protected async Task<T> Fetch<T>(IRequest request)
    {
        var resp = await _httpClient.GetAsync($"{_settings.BaseUrl}{request.QueryString}");
        var responseContent = resp.Content;

        var objectResponse = await JsonSerializer.DeserializeAsync<T>(await responseContent.ReadAsStreamAsync());

        return objectResponse ?? throw new Exception();
    }
}