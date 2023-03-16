using System.Diagnostics.Contracts;
using Yanoac.ClientV2.Models.Beatmap;

namespace Yanoac.IntegrationTests.Helpers;

public static class BeatmapTestExtensions
{
    [Pure]
    public static Beatmap AsTestable(this Beatmap beatmap) =>
        beatmap with
        {
            PlayCount = default,
            PassCount = default,
        };
}