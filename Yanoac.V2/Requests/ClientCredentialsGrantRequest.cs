using System.Collections.Generic;
using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class ClientCredentialsGrantRequest : IRequestWithForm
{
    public string QueryString => $"https://osu.ppy.sh/oauth/token";

    private static string grantType => "client_credentials";
    private static string scope => "public";
    public string ClientId { get; set; } = null!;
    public string ClientSecret { get; set; } = null!;

    public Dictionary<string, string> Form => new()
    {
        { "client_id", ClientId },
        { "client_secret", ClientSecret },
        { "grant_type", grantType },
        { "scope", scope },
    };
}
