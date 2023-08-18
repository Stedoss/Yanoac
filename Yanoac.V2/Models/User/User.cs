using System;
using System.Text.Json.Serialization;

namespace Yanoac.V2.Models.User;

public record User
{
    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    [JsonPropertyName("default_group")]
    public string DefaultGroup { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    [JsonPropertyName("is_bot")]
    public bool IsBot { get; set; }

    [JsonPropertyName("is_deleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("is_online")]
    public bool IsOnline { get; set; }

    [JsonPropertyName("is_supporter")]
    public bool IsSupporter { get; set; }

    [JsonPropertyName("last_visit")]
    public DateTime LastVisit { get; set; }

    [JsonPropertyName("pm_friends_only")]
    public bool PmFriendsOnly { get; set; }

    [JsonPropertyName("profile_colour")]
    public string? ProfileColour { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("country")]
    public Country Country { get; set; }

    [JsonPropertyName("cover")]
    public UserCover Cover { get; set; }

    [JsonPropertyName("groups")]
    public string[] Groups { get; set; }
}

public record Country
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public record UserCover
{
    [JsonPropertyName("custom_url")]
    public string? CustomUrl { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}
