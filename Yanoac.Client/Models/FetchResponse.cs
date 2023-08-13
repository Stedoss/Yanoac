using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Yanoac.Client.Models;

public class FetchResponse
{
    private readonly HttpResponseMessage _httpResponseMessage;
    
    public FetchResponse(HttpResponseMessage httpResponseMessage)
    {
        _httpResponseMessage = httpResponseMessage;
    }

    public HttpStatusCode StatusCode => _httpResponseMessage.StatusCode;

    public bool IsSuccessStatusCode => _httpResponseMessage.IsSuccessStatusCode;

    public async Task<T?> ContentAsJson<T>() => await JsonSerializer.DeserializeAsync<T>(await _httpResponseMessage.Content.ReadAsStreamAsync());
    
    public async Task<string> ContentAsString() => await _httpResponseMessage.Content.ReadAsStringAsync();
}