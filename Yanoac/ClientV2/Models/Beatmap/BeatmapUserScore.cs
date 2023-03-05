﻿using System.Text.Json.Serialization;

namespace Yanoac.ClientV2.Models.Beatmap;

public record BeatmapUserScore
{
    [JsonPropertyName("position")]
    public int Position { get; set; }
    
    [JsonPropertyName("score")]
    public ScoreModel Score { get; set; }
}