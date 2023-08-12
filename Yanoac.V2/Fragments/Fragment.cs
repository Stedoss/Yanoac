using System.Net.Http;
using Yanoac.Client;

namespace Yanoac.V2.Fragments;

public abstract class Fragment
{
    private readonly OsuHttpClient _httpClient;
    private readonly OsuClientV2Settings _settings;
    
    protected Fragment(OsuHttpClient httpClient, OsuClientV2Settings settings)
    {
        _httpClient = httpClient;
        _settings = settings;
    }

    protected OsuHttpClient Client => _httpClient;

    protected HttpClient UnderlyingClient => _httpClient.Client;
}