using System.Text.Json.Serialization;

namespace Yanoac.V2.Models.Beatmap;

public record BeatmapSetCompact
{
    [JsonPropertyName("artist")]
    public string Artist { get; set; } = null!;

    [JsonPropertyName("artist_unicode")]
    public string ArtistUnicode { get; set; } = null!;

    [JsonPropertyName("covers")]
    public BeatmapCovers Covers { get; set; } = null!;

    [JsonPropertyName("creator")]
    public string Creator { get; set; } = null!;

    [JsonPropertyName("favourite_count")]
    public int FavouriteCount { get; set; }

    [JsonPropertyName("hype")]
    public object? Hype { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nsfw")]
    public bool Nsfw { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("play_count")]
    public long PlayCount { get; set; }

    [JsonPropertyName("preview_url")]
    public string PreviewUrl { get; set; } = null!;

    [JsonPropertyName("source")]
    public string Source { get; set; } = null!;

    [JsonPropertyName("spotlight")]
    public bool Spotlight { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("title_unicode")]
    public string TitleUnicode { get; set; } = null!;

    [JsonPropertyName("track_id")]
    public int? TrackId { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("video")]
    public bool Video { get; set; }
}

public record BeatmapCovers
{
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    [JsonPropertyName("cover@2x")]
    public string Cover2x { get; set; }

    [JsonPropertyName("card")]
    public string Card { get; set; }

    [JsonPropertyName("card@2x")]
    public string Card2x { get; set; }

    [JsonPropertyName("list")]
    public string List { get; set; }

    [JsonPropertyName("list@2x")]
    public string List2x { get; set; }

    [JsonPropertyName("slimcover")]
    public string SlimCover { get; set; }

    [JsonPropertyName("slimcover@2x")]
    public string SlimCover2x { get; set; }
}
