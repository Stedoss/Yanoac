﻿using System.Threading.Tasks;
using NUnit.Framework;
using Yanoac.IntegrationTests.Bases;
using Yanoac.IntegrationTests.Data;
using Yanoac.IntegrationTests.Helpers;
using Yanoac.V2.Models.Beatmap;
using Yanoac.V2.Requests;

namespace Yanoac.IntegrationTests.Partials;

[TestFixture]
public class BeatmapsFragmentTests : AuthenticatedClientTest
{
    [Test, TestCaseSource(nameof(testBeatmaps))]
    public async Task LookupBeatmap_ReturnsCorrectModel_WhenRequestObjectIsPassed(Beatmap testBeatmap)
    {
        var beatmap = await Client.LookupBeatmap(new LookupBeatmapRequest { Id = testBeatmap.Id });

        Assert.That(beatmap?.AsTestable(), Is.EqualTo(testBeatmap.AsTestable()));
    }

    [Test, TestCaseSource(nameof(testBeatmaps))]
    public async Task LookupBeatmap_ReturnsCorrectModel_WhenRawParametersPassed(Beatmap testBeatmap)
    {
        var beatmap = await Client.LookupBeatmap(1860433);

        Assert.That(beatmap?.AsTestable(), Is.EqualTo(testBeatmap.AsTestable()));
    }

    [Test]
    public async Task GetUserBeatmapScore_ReturnsCorrectModel_WhenRequestObjectIsPassed()
    {
        _ = await Client.GetUserBeatmapScore(new UserBeatmapScoreRequest { BeatmapId = 95202, UserId = 8331546 });
    }

    [Test]
    public async Task GetUserBeatmapScore_ReturnsCorrectModel_WhenRawParametersPassed()
    {
        _ = await Client.GetUserBeatmapScore(95202, 8331546);
    }

    private static Beatmap[] testBeatmaps => BeatmapTestData.TestBeatmaps;
}
