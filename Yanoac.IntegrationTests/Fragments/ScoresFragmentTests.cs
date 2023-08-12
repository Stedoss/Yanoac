using System.Threading.Tasks;
using NUnit.Framework;
using Yanoac.IntegrationTests.Bases;

namespace Yanoac.IntegrationTests.Fragments;

public class ScoresFragmentTests : AuthenticatedAuthCodeClientTest
{
    [Test]
    public async Task ScoreDownload()
    {
        var replay = await Client.Scores.DownloadScore("osu", "2610098209");

        Assert.That(replay, Is.Not.Null);
    }
}