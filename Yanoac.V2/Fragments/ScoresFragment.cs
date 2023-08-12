using System.Threading.Tasks;
using Yanoac.Client;
using Yanoac.V2.Requests;

namespace Yanoac.V2.Fragments;

public class ScoresFragment : Fragment
{
    public ScoresFragment(OsuHttpClient httpClient, OsuClientV2Settings settings) : base(httpClient, settings)
    {
    }

    public async Task<string> DownloadScore(string mode, string score)
    {
        var request = new DownloadScoreRequest
        {
            Mode = mode,
            Score = score
        };

        return await Client.FetchAsString(request);
    }
}