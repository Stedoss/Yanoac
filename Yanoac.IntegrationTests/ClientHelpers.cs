using System;
using Yanoac.V2;

namespace Yanoac.IntegrationTests;

public static class ClientHelpers
{
    public static OsuClientV2 AuthenticatedTestClient { get; } = new()
    {
        Settings = new OsuClientV2Settings
        {
            ClientId = Environment.GetEnvironmentVariable("YANOAC_TEST_CLIENT_ID", EnvironmentVariableTarget.User)!,
            ClientSecret = Environment.GetEnvironmentVariable("YANOAC_TEST_CLIENT_SECRET", EnvironmentVariableTarget.User)!,
        }
    };

    public static OsuClientV2 AuthenticationCodeTestClient { get; } = new()
    {
        Settings = new OsuClientV2Settings
        {
            ClientId = Environment.GetEnvironmentVariable("YANOAC_TEST_CLIENT_ID", EnvironmentVariableTarget.User)!,
            ClientSecret = Environment.GetEnvironmentVariable("YANOAC_TEST_CLIENT_SECRET", EnvironmentVariableTarget.User)!,
        }
    };
}