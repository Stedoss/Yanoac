using Yanoac.V2.Models.Beatmap;

namespace Yanoac.IntegrationTests.Helpers;

public static class BeatmapSetTestExtensions
{
    public static BeatmapSetCompact AsTestable(this BeatmapSetCompact beatmapSet) =>
        beatmapSet with { FavouriteCount = default, PlayCount = default };
}
