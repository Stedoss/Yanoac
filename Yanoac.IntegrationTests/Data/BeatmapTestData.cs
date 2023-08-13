using System;
using Yanoac.V2.Models.Beatmap;

namespace Yanoac.IntegrationTests.Data;

public static class BeatmapTestData
{
    public static Beatmap[] TestBeatmaps => new[]
    {
        new Beatmap
        {
            BeatmapSetId = 863227,
            DifficultyRating = 6.39f,
            Id = 1860433,
            Mode = "osu",
            Status = "ranked",
            TotalLength = 90,
            UserId = 3533958,
            Version = "Fiery's Extreme",
            Accuracy = 9.2f,
            Ar = 9.4f,
            Bpm = 204,
            Convert = false,
            CountCircles = 167,
            CountSliders = 185,
            CountSpinners = 0,
            Cs = 4,
            DeletedAt = null,
            Drain = 5,
            HitLength = 89,
            IsScoreable = true,
            LastUpdated = new DateTime(2018, 12, 10, 22, 37, 23),
            ModeInt = 0,
            PassCount = 551340,
            PlayCount = 4038129,
            Ranked = 1,
            Url = "https://osu.ppy.sh/beatmaps/1860433",
            Checksum = "9ab06c1c07c0a2b14085991e19bd2441"
        }
    };
}
