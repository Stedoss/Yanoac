using System.Threading.Tasks;
using NUnit.Framework;
using Yanoac.ClientV2;
using Yanoac.IntegrationTests.Bases;

namespace Yanoac.IntegrationTests;

public class OsuClientV2Tests : AuthenticatedClientTest
{
    [Test]
    public async Task Authorise_AuthenticatesWithApi()
    {
        var client = ClientHelpers.AuthenticatedTestClient;

        await client.Authorise();

        Assert.That(client.IsAuthenticated, Is.True);
    }
}