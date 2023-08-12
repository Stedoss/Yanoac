using System.Threading.Tasks;
using Yanoac.Client;
using Yanoac.V2.Models.Beatmap;
using Yanoac.V2.Requests;

namespace Yanoac.V2.Fragments;

public class BeatmapsFragment : Fragment
{
    public BeatmapsFragment(OsuHttpClient httpClient, OsuClientV2Settings settings) : base(httpClient, settings)
    {
    }

    public async Task<Beatmap> LookupBeatmap(LookupBeatmapRequest request)
    {
        return await Client.Fetch<Beatmap>(request);
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
        return await Client.Fetch<BeatmapUserScore>(request);
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