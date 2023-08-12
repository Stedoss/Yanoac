using System.Text.Json.Serialization;
using System.Web;
using Yanoac.Client;

namespace Yanoac.V2.Requests;

public class AuthorizationCodeGrantTokenRequest : IRequest
{
    [JsonIgnore]
    public string Endpoint => $"https://osu.ppy.sh/oauth/token?{getQueryStringParameters()}";

    [JsonIgnore]
    public string QueryString => Endpoint;
    
    [JsonPropertyName("client_id")]
    public string ClientId { get; set; }
    
    [JsonPropertyName("client_secret")]
    public string ClientSecret { get; set; }
    
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("grant_type")]
    public string GrantType => "authorization_code";

    [JsonPropertyName("redirect_uri")]
    public string RedirectUri { get; set; }
    
    private string getQueryStringParameters()
    {
        var queryString = HttpUtility.ParseQueryString(string.Empty);

        queryString.Add("client_id", ClientId);
        queryString.Add("client_secret", ClientSecret);
        queryString.Add("redirect_uri", RedirectUri);
        queryString.Add("grant_type", GrantType);
        queryString.Add("code", Code);

        return queryString.ToString();
    }
}