using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Yanoac.IntegrationTests.Bases;
using Yanoac.IntegrationTests.Data;
using Yanoac.IntegrationTests.Helpers;

namespace Yanoac.IntegrationTests.Partials;

public class ScoresFragmentTests : AuthenticatedAuthCodeClientTest
{
    [Test]
    public async Task GetScore()
    {
        var testScore = ScoreTestData.TestScores.First();

        var score = await Client.GetScore("osu", testScore.Id);

        score.AsTestable().Should().BeEquivalentTo(testScore.AsTestable());
    }

    [Test]
    public async Task ScoreDownload()
    {
        byte[] replay = await Client.DownloadScore("osu", "2610098209");

        Assert.That(replay, Is.Not.Null);
    }
}
