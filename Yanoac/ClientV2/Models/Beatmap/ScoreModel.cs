using System;
using System.Text.Json.Serialization;

namespace Yanoac.ClientV2.Models.Beatmap;

public record ScoreModel
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
    
    [JsonPropertyName("best_id")]
    public long BestId { get; set; }
    
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
    
    [JsonPropertyName("accuracy")]
    public float Accuracy { get; set; }
    
    [JsonPropertyName("mods")]
    public string[] Mods { get; set; }
    
    [JsonPropertyName("score")]
    public int Score { get; set; }
    
    [JsonPropertyName("max_combo")]
    public int MaxCombo { get; set; }
    
    [JsonPropertyName("beatmap_id")]
    public int BeatmapId { get; set; }
    
    [JsonPropertyName("ended_at")]
    public DateTime EndedAt { get; set; }
    
    [JsonPropertyName("passed")]
    public bool Passed { get; set; }
    
    [JsonPropertyName("rank")]
    public string Rank { get; set; }
    
    [JsonPropertyName("ruleset_id")]
    public int RulesetId { get; set; }
    
    [JsonPropertyName("total_score")]
    public int TotalScore { get; set; }
    
    [JsonPropertyName("legacy_perfect")]
    public bool LegacyPerfect { get; set; }
    
    [JsonPropertyName("pp")]
    public float Pp { get; set; }
    
    [JsonPropertyName("replay")]
    public bool Replay { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    [JsonPropertyName("beatmap")]
    public Beatmap Beatmap { get; set; } 
}