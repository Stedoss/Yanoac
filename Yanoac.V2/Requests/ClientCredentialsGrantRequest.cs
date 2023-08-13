using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Web;
using Yanoac.Client;
using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class ClientCredentialsGrantRequest : IRequestWithForm
{
    public string QueryString => $"https://osu.ppy.sh/oauth/token";
    
    private static string GrantType => "client_credentials";
    private static string Scope => "public";
    public string ClientId { get; set; } = null!;
    public string ClientSecret { get; set; } = null!;

    public Dictionary<string, string> Form => new()
    {
        { "client_id", ClientId },
        { "client_secret", ClientSecret },
        { "grant_type", GrantType },
        { "scope", Scope },
    };
}