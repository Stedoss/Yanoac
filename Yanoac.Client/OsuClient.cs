using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Yanoac.Client;

public class OsuClient
{
    public OsuClient(HttpClient? client = null)
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
    
    public async Task<T> Post<T>(IRequestWithForm request)
    {
        
        var resp = await Client.PostAsync(request.QueryString, new FormUrlEncodedContent(request.Form));
        var responseContent = resp.Content;
        

        var objectResponse = await JsonSerializer.DeserializeAsync<T>(await responseContent.ReadAsStreamAsync());

        return objectResponse ?? throw new Exception();
    }
}
