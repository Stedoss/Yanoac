using System.Text.Json.Serialization;

namespace Yanoac.V2.Models.Beatmap;

public record BeatmapWithBeatmapSet : Beatmap
{
    [JsonPropertyName("beatmapset")]
    public BeatmapSet BeatmapSet { get; set; } = null!;
}
