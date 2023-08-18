using Yanoac.V2.Models.Score;

namespace Yanoac.IntegrationTests.Helpers;

public static class UserScoreTestExtensions
{
    public static UserScore AsTestable(this UserScore userScore) =>
        userScore with
        {
            Beatmap = userScore.Beatmap.AsTestable(),
            User = userScore.User.AsTestable(),
            Beatmapset = userScore.Beatmapset.AsTestable(),
            RankGlobal = default
        };
}
