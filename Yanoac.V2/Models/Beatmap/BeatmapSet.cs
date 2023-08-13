using System;

namespace Yanoac.V2.Models.Beatmap;

public record BeatmapSet
{
    public string Artist { get; set; } = null!;
    public string ArtistUnicode { get; set; } = null!;
    public object Covers { get; set; } = null!;
    public string Creator { get; set; } = null!;
    public int FavouriteCount { get; set; }
    public object? Hype { get; set; }
    public int Id { get; set; }
    public bool Nsfw { get; set; }
    public int Offset { get; set; }
    public long PlayCount { get; set; }
    public string PreviewUrl { get; set; } = null!;
    public string Source { get; set; } = null!;
    public bool Spotlight { get; set; }
    public string Status { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string TitleUnicode { get; set; } = null!;
    public int TrackId { get; set; }
    public int UserId { get; set; }
    public bool Video { get; set; }
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
