using Yanoac.V2.Models.User;

namespace Yanoac.IntegrationTests.Helpers;

public static class UserTestExtensions
{
    public static User AsTestable(this User user) =>
        user with { AvatarUrl = default!, IsOnline = default, LastVisit = default, ProfileColour = default };
}
