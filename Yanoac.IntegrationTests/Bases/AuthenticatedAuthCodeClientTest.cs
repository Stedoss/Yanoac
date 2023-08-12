using NUnit.Framework;
using Yanoac.V2;

namespace Yanoac.IntegrationTests.Bases;

public class AuthenticatedAuthCodeClientTest
{
    [SetUp]
    public void SetUp()
    {
        Client = ClientHelpers.AuthenticationCodeTestClient;
    }
    
    protected OsuClientV2 Client { get; private set; } = null!;
}