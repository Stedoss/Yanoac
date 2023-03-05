using System;
using Yanoac.ClientV2;

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
}