using System;
using Yanoac.V2.Models.Beatmap;
using Yanoac.V2.Models.Score;
using Yanoac.V2.Models.User;

namespace Yanoac.IntegrationTests.Data;

public static class ScoreTestData
{
    public static UserScore[] TestScores => new[]
    {
        new UserScore
        {
            Accuracy = 0.9883286647992531f,
            BestId = 2610098209,
            CreatedAt = new DateTime(2018, 08, 17, 14, 40, 33),
            Id = 2610098209,
            MaxCombo = 507,
            Mode = "osu",
            ModeInt = 0,
            Mods = Array.Empty<string>(),
            Passed = true,
            Perfect = false,
            Pp = 223.847f,
            Rank = "S",
            Replay = true,
            Score = 4569706,
            Statistics = new ScoreStatistics
            {
                Count100 = 5,
                Count300 = 351,
                Count50 = 1,
                CountGeki = 87,
                CountKatu = 5,
                CountMiss = 0
            },
            Type = "score_best_osu",
            UserId = 8331546,
            CurrentUserAttributes = new CurrentUserAttributes
            {
                Pin = new PinUserAttribute
                {
                    IsPinned = false,
                    ScoreId = 2610098209,
                    ScoreType = "score_best_osu"
                }
            },
            Beatmap = new Beatmap
            {
                BeatmapSetId = 781509,
                DifficultyRating = 5.81f,
                Id = 1643270,
                Mode = "osu",
                Status = "ranked",
                TotalLength = 86,
                UserId = 899031,
                Version = "Lami's Extra",
                Accuracy = 9,
                Ar = 9.3f,
                Bpm = 204,
                Convert = false,
                CountCircles = 212,
                CountSliders = 144,
                CountSpinners = 1,
                Cs = 3.8f,
                DeletedAt = null,
                Drain = 5.2f,
                HitLength = 85,
                IsScoreable = true,
                LastUpdated = new DateTime(2018, 07, 17, 21, 38, 53),
                ModeInt = 0,
                PassCount = 490860, //
                PlayCount = 5693526, //
                Ranked = 1,
                Url = "https://osu.ppy.sh/beatmaps/1643270",
                Checksum = "7f3160713f6d0eb635f8b5deef5e1aaf",
            },
            Beatmapset = new BeatmapSetCompact
            {
                Artist = "Vickeblanka",
                ArtistUnicode = "ビッケブランカ",
                Covers = new BeatmapCovers
                {
                    Cover = "https://assets.ppy.sh/beatmaps/781509/covers/cover.jpg?1650664944",
                    Cover2x = "https://assets.ppy.sh/beatmaps/781509/covers/cover@2x.jpg?1650664944",
                    Card = "https://assets.ppy.sh/beatmaps/781509/covers/card.jpg?1650664944",
                    Card2x = "https://assets.ppy.sh/beatmaps/781509/covers/card@2x.jpg?1650664944",
                    List = "https://assets.ppy.sh/beatmaps/781509/covers/list.jpg?1650664944",
                    List2x = "https://assets.ppy.sh/beatmaps/781509/covers/list@2x.jpg?1650664944",
                    SlimCover = "https://assets.ppy.sh/beatmaps/781509/covers/slimcover.jpg?1650664944",
                    SlimCover2x = "https://assets.ppy.sh/beatmaps/781509/covers/slimcover@2x.jpg?1650664944",
                },
                Creator = "Sotarks",
                FavouriteCount = 0, //
                Hype = null,
                Id = 781509,
                Nsfw = false,
                Offset = 0,
                PlayCount = 80616438, //
                PreviewUrl = "//b.ppy.sh/preview/781509.mp3",
                Source = "ブラッククローバー",
                Spotlight = false,
                Status = "ranked",
                Title = "Black Rover (TV Size)",
                TitleUnicode = "Black Rover (TV Size)",
                TrackId = null,
                UserId = 4452992,
                Video = true,
            },
            RankGlobal = 8612, //
            User = new User
            {
                AvatarUrl = "https://a.ppy.sh/8331546?1581614235.jpeg", //
                CountryCode = "GB",
                DefaultGroup = "default",
                Id = 8331546,
                IsActive = true,
                IsBot = false,
                IsDeleted = false,
                IsOnline = false, //
                IsSupporter = false,
                LastVisit = default, //
                PmFriendsOnly = false,
                ProfileColour = null, //
                Username = "Stedoss",
                Country = new Country
                {
                    Code = "GB",
                    Name = "United Kingdom",
                },
                Cover = new UserCover
                {
                    CustomUrl = null,
                    Url = "https://osu.ppy.sh/images/headers/profile-covers/c3.jpg",
                    Id = "3"
                },
                Groups = Array.Empty<string>(),
            }
        }
    };
}
