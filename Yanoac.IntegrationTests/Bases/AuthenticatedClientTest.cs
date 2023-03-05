using NUnit.Framework;
using Yanoac.ClientV2;

namespace Yanoac.IntegrationTests.Bases;

[TestFixture]
public abstract class AuthenticatedClientTest
{
    [SetUp]
    public void SetUp()
    {
        Client = ClientHelpers.AuthenticatedTestClient;
    }

    protected OsuClientV2 Client { get; private set; } = null!;
}