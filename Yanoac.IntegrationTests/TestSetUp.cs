using System.Threading.Tasks;
using NUnit.Framework;

namespace Yanoac.IntegrationTests;

[SetUpFixture]
public class TestSetUp
{
    [OneTimeSetUp]
    public async Task SetUp()
    {
        await ClientHelpers.AuthenticatedTestClient.Authorise();
        await ClientHelpers.AuthenticationCodeTestClient.Authorise("http://localhost:4567/");
    }
}