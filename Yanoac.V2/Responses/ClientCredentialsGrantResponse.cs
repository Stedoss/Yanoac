﻿using System.Text.Json.Serialization;
using Yanoac.V2.Models.Authentication;

namespace Yanoac.V2.Responses;

public class ClientCredentialsGrantResponse
{
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = null!;

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = null!;

    public ClientCredentialsAccessToken ToAccessToken() => new()
    {
        Token = AccessToken,
        ExpiresIn = ExpiresIn,
    };
}
