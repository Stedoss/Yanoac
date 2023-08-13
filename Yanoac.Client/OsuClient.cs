using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Yanoac.Client.Models;

namespace Yanoac.Client;

public abstract class OsuClient
{
    protected OsuClient(HttpClient? client = null)
    {
        client ??= new HttpClient();

        Client = client;
    }

    protected HttpClient Client { get; }

    protected virtual async Task<FetchResponse> Fetch(IRequest request) =>
        new(await Client.GetAsync(request.QueryString));

    protected async Task<T> Post<T>(IRequestWithForm request)
    {

        var resp = await Client.PostAsync(request.QueryString, new FormUrlEncodedContent(request.Form));
        var responseContent = resp.Content;


        var objectResponse = await JsonSerializer.DeserializeAsync<T>(await responseContent.ReadAsStreamAsync());

        return objectResponse ?? throw new Exception();
    }
}
