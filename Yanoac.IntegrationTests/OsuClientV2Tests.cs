using NUnit.Framework;

namespace Yanoac.IntegrationTests;

public class OsuClientV2Tests
{
    [Test]
    public void Authorise_AuthenticatesWithApi()
    {
        var client = ClientHelpers.AuthenticatedTestClient;

        Assert.That(client.IsAuthenticated, Is.True);
    }

    [Test]
    public void Authorise_ACG_AuthenticatedWithApi()
    {
        var client = ClientHelpers.AuthenticationCodeTestClient;
        
        Assert.That(client.IsAuthenticated, Is.True);
    }
}