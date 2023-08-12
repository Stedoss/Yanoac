using System.Text.Json.Serialization;
using Yanoac.Client;
using Yanoac.V2.Responses;

namespace Yanoac.V2.Requests;

public class ClientCredentialsGrantRequest : IRequest
{
    public string Endpoint => "https://osu.ppy.sh/oauth/token";

    public string QueryString => Endpoint;
    
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; }
    
    [JsonPropertyName("client_secret")]
    public string ClientSecret { get; set; }

    [JsonPropertyName("grant_type")]
    public string GrantType => "client_credentials";
    
    [JsonPropertyName("scope")]
    public string Scope => "public";
}