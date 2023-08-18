using System;
using System.Text.Json.Serialization;
using Yanoac.V2.Models.Beatmap;

namespace Yanoac.V2.Models.Score;

public record UserScore
{
    [JsonPropertyName("accuracy")]
    public float Accuracy { get; set; }

    [JsonPropertyName("best_id")]
    public long BestId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("max_combo")]
    public int MaxCombo { get; set; }

    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    [JsonPropertyName("mode_int")]
    public int ModeInt { get; set; }

    [JsonPropertyName("mods")]
    public string[] Mods { get; set; }

    [JsonPropertyName("passed")]
    public bool Passed { get; set; }

    [JsonPropertyName("perfect")]
    public bool Perfect { get; set; }

    [JsonPropertyName("pp")]
    public float Pp { get; set; }

    [JsonPropertyName("rank")]
    public string Rank { get; set; }

    [JsonPropertyName("replay")]
    public bool Replay { get; set; }

    [JsonPropertyName("score")]
    public long Score { get; set; }

    [JsonPropertyName("statistics")]
    public ScoreStatistics Statistics { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("current_user_attributes")]
    public CurrentUserAttributes CurrentUserAttributes { get; set; }

    [JsonPropertyName("beatmap")]
    public Beatmap.Beatmap Beatmap { get; set; }

    [JsonPropertyName("beatmapset")]
    public BeatmapSetCompact Beatmapset { get; set; }

    [JsonPropertyName("rank_global")]
    public long RankGlobal { get; set; }

    [JsonPropertyName("user")]
    public User.User User { get; set; }
}

public record ScoreStatistics
{
    [JsonPropertyName("count_100")]
    public int Count100 { get; set; }

    [JsonPropertyName("count_300")]
    public int Count300 { get; set; }

    [JsonPropertyName("count_50")]
    public int Count50 { get; set; }

    [JsonPropertyName("count_geki")]
    public int CountGeki { get; set; }

    [JsonPropertyName("count_katu")]
    public int CountKatu { get; set; }

    [JsonPropertyName("count_miss")]
    public int CountMiss { get; set; }
}

public record CurrentUserAttributes
{
    [JsonPropertyName("pin")]
    public PinUserAttribute Pin { get; set; }
}

public record PinUserAttribute
{
    [JsonPropertyName("is_pinned")]
    public bool IsPinned { get; set; }

    [JsonPropertyName("score_id")]
    public long ScoreId { get; set; }

    [JsonPropertyName("score_type")]
    public string ScoreType { get; set; }
}
