using System.Threading.Tasks;
using NUnit.Framework;

namespace Yanoac.IntegrationTests;

public class OsuClientV2Tests
{
    [Test]
    public async Task Authorise_AuthenticatesWithApi()
    {
        var client = ClientHelpers.AuthenticatedTestClient;

        await client.Authorise();

        Assert.That(client.IsAuthenticated, Is.True);
    }

    [Test]
    public async Task Authorise_ACG_AuthenticatedWithApi()
    {
        var client = ClientHelpers.AuthenticationCodeTestClient;
        
        await client.Authorise("http://localhost:4567/");
        
        Assert.That(client.IsAuthenticated, Is.True);
    }
}