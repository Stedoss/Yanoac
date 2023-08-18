using System.IO;
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

    [TestCaseSource(nameof(test_score_list))]
    public async Task GetScore_ParsesWithoutErrors((string, long) score)
    {
        var getScore = async () => await Client.GetScore(score.Item1, score.Item2);

        await getScore.Should().NotThrowAsync();
    }

    [Test]
    public async Task ScoreDownload()
    {
        byte[] localReplay = await File.ReadAllBytesAsync("Assets\\2177560145.osr");

        byte[] downloadedReplay = await Client.DownloadScore("osu", "2177560145");

        Assert.That(downloadedReplay, Is.EqualTo(localReplay));
    }

    private static readonly (string, long)[] test_score_list =
    {
        ("osu", 2716015058),
        ("osu", 2702383046),
        ("osu", 4491294030),
        ("osu", 4478711346),
        ("osu", 4491286592),
        ("osu", 3948818994),
        ("osu", 4298439387),
        ("osu", 2177560145),
        ("mania", 222046829),
        ("mania", 491815877),
        ("mania", 544800408),
        ("taiko", 179488881),
        ("taiko", 180342921),
        ("catch", 208579641),
        ("catch", 210593305),
    };
}
