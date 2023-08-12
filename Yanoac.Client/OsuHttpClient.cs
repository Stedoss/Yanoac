using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Yanoac.Client;

public class OsuHttpClient
{
    public OsuHttpClient(HttpClient? client = null)
    {
        client ??= new HttpClient();

        Client = client;
    }
    
    public HttpClient Client { get; }
    
    public async Task<T> Fetch<T>(IRequest request)
    {
        var resp = await Client.GetAsync(request.QueryString);
        var responseContent = resp.Content;

        var objectResponse = await JsonSerializer.DeserializeAsync<T>(await responseContent.ReadAsStreamAsync());

        return objectResponse ?? throw new Exception();
    }
    
    public async Task<string> FetchAsString(IRequest request)
    {
        var resp = await Client.GetAsync(request.QueryString);
        var responseContent = resp.Content;

        return await responseContent.ReadAsStringAsync() ?? throw new Exception();
    }
    
    public async Task<T> Post<T>(IRequest request)
    {
        var resp = await Client.PostAsync(request.QueryString,
            new StringContent(JsonSerializer.Serialize(request as object), Encoding.UTF8, "application/json"));
        var responseContent = resp.Content;

        var objectResponse = await JsonSerializer.DeserializeAsync<T>(await responseContent.ReadAsStreamAsync());

        return objectResponse ?? throw new Exception();
    }
}
