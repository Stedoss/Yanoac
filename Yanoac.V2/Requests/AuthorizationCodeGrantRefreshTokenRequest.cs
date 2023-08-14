using System.Collections.Generic;
using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class AuthorizationCodeGrantRefreshTokenRequest : IRequestWithForm
{
    public string QueryString => "https://osu.ppy.sh/oauth/token";

    private const string grant_type = "refresh_token";
    private const string scope = "public";

    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string RefreshToken { get; set; }

    public Dictionary<string, string> Form => new()
    {
        { "client_id", ClientId },
        { "client_secret", ClientSecret },
        { "grant_type", grant_type },
        { "refresh_token", RefreshToken },
        { "scope", scope },
    };
}
