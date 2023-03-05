using System.Text.Json.Serialization;

namespace Yanoac.ClientV2.Models.Beatmap;

public record BeatmapCompact
{
    [JsonPropertyName("beatmapset_id")]
    public int BeatmapSetId { get; set; }
    
    [JsonPropertyName("difficulty_rating")]
    public float DifficultyRating { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("mode")]
    public string Mode { get; set; }
    
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    [JsonPropertyName("total_length")]
    public int TotalLength { get; set; }
    
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
    
    [JsonPropertyName("version")]
    public string Version { get; set; }
}