using System.Collections.Generic;
using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class AuthorizationCodeGrantTokenRequest : IRequestWithForm
{
    public string QueryString => $"https://osu.ppy.sh/oauth/token";

    private static string grantType => "authorization_code";
    public string ClientId { get; set; } = null!;
    public string ClientSecret { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string RedirectUri { get; set; } = null!;

    public Dictionary<string, string> Form => new()
    {
        { "client_id", ClientId },
        { "client_secret", ClientSecret },
        { "redirect_uri", RedirectUri },
        { "grant_type", grantType },
        { "code", Code },
    };
}
