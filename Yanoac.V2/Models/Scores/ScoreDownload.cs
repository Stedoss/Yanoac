using System.Text.Json.Serialization;

namespace Yanoac.V2.Models.Scores;

public record ScoreDownload
{
    [JsonPropertyName("mode")]
    public string Mode { get; set; }
    
    [JsonPropertyName("score")]
    public string Score { get; set; }
}