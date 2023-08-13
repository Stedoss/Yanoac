using System.Threading.Tasks;
using Yanoac.V2.Models.Beatmap;
using Yanoac.V2.Requests;

namespace Yanoac.V2;

public partial class OsuClientV2
{
    public async Task<Beatmap> LookupBeatmap(LookupBeatmapRequest request)
    {
        return await Fetch<Beatmap>(request);
    }

    public async Task<Beatmap> LookupBeatmap(int? id = null, string? filename = null, string? checksum = null)
    {
        var request = new LookupBeatmapRequest
        {
            Id = id,
            Filename = filename,
            Checksum = checksum
        };

        return await LookupBeatmap(request);
    }

    public async Task<BeatmapUserScore> GetUserBeatmapScore(UserBeatmapScoreRequest request)
    {
        return await Fetch<BeatmapUserScore>(request);
    }

    public async Task<BeatmapUserScore> GetUserBeatmapScore(int beatmapId, int userId)
    {
        var request = new UserBeatmapScoreRequest
        {
            BeatmapId = beatmapId,
            UserId = userId
        };

        return await GetUserBeatmapScore(request);
    }
}