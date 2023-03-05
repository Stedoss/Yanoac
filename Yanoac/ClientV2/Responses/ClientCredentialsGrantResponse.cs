using System.Text.Json.Serialization;
using Yanoac.ClientV2.Models;

namespace Yanoac.ClientV2.Responses;

public class ClientCredentialsGrantResponse
{
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }
    
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
    
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
    
    public AccessToken ToAccessToken() => new()
    {
        Token = AccessToken,
        ExpiresIn = ExpiresIn,
    };
}