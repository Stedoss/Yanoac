using System.Web;
using Yanoac.Client;
using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class AuthorizationCodeGrantRequest : IRequest
{
    public string Endpoint => "https://osu.ppy.sh/oauth/authorize";
    public string QueryString => $"{Endpoint}?{getQueryStringParameters()}";
    
    public string ClientId { get; set; }
    public string RedirectUri { get; set; }
    
    private string getQueryStringParameters()
    {
        var queryString = HttpUtility.ParseQueryString(string.Empty);

        queryString.Add("client_id", ClientId);
        queryString.Add("redirect_uri", RedirectUri);
        queryString.Add("response_type", "code");
        queryString.Add("scope", "public");
        // queryString.Add("state", "someval");

        return queryString.ToString();
    }
}