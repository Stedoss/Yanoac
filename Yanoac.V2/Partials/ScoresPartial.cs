using System.Threading.Tasks;
using Yanoac.V2.Requests;

namespace Yanoac.V2;

public partial class OsuClientV2
{
    public async Task<byte[]> DownloadScore(string mode, string score)
    {
        var request = new DownloadScoreRequest
        {
            Mode = mode,
            Score = score
        };

        var fetchResponse = await Fetch(request);

        return await fetchResponse.ContentAsByteArray();
    }
}
