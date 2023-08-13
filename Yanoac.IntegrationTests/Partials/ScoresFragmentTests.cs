using System.Threading.Tasks;
using NUnit.Framework;
using Yanoac.IntegrationTests.Bases;

namespace Yanoac.IntegrationTests.Partials;

public class ScoresFragmentTests : AuthenticatedAuthCodeClientTest
{
    [Test]
    public async Task ScoreDownload()
    {
        string replay = await Client.DownloadScore("osu", "2610098209");

        Assert.That(replay, Is.Not.Null);
    }
}
