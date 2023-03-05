using System.Text.Json.Serialization;

namespace Yanoac.ClientV2.Requests;

public class ClientCredentialsGrantRequest : IRequest
{
    [JsonIgnore]
    public string Endpoint => "https://osu.ppy.sh/oauth/token";

    [JsonIgnore]
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