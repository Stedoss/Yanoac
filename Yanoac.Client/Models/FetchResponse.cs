using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Yanoac.Client.Models;

public class FetchResponse
{
    private readonly HttpResponseMessage httpResponseMessage;

    public FetchResponse(HttpResponseMessage responseMessage)
    {
        httpResponseMessage = responseMessage;
    }

    public HttpStatusCode StatusCode => httpResponseMessage.StatusCode;

    public bool IsSuccessStatusCode => httpResponseMessage.IsSuccessStatusCode;

    public async Task<T?> ContentAsJson<T>() => await JsonSerializer.DeserializeAsync<T>(await httpResponseMessage.Content.ReadAsStreamAsync());

    public async Task<string> ContentAsString() => await httpResponseMessage.Content.ReadAsStringAsync();
}
