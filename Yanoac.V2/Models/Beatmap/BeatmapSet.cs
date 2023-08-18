using System;

namespace Yanoac.V2.Models.Beatmap;

public record BeatmapSet : BeatmapSetCompact
{
    public int Bpm { get; set; }
    public bool CanBeHyped { get; set; }
    public DateTime DeletedAt { get; set; }
    public bool DiscussionEnabled { get; set; }
    public bool DiscussionLocked { get; set; }
    public bool IsScoreable { get; set; }
    public DateTime LastUpdated { get; set; }
    public string LegacyThreadUrl { get; set; } = null!;
    public object NominationsSummary { get; set; } = null!;
    public int Ranked { get; set; }
    public DateTime RankedDate { get; set; }
    public bool Storyboard { get; set; }
    public DateTime SubmittedDate { get; set; }
    public string Tags { get; set; } = null!;
    public object Availability { get; set; } = null!;
    public int[] Ratings { get; set; } = null!;
}
