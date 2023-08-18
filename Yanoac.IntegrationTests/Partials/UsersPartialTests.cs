using System;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Yanoac.IntegrationTests.Bases;

namespace Yanoac.IntegrationTests.Partials;

public class UsersPartialTests : AuthenticatedClientTest
{
    [Test]
    public async Task GetUsers_WithNoParams_ThrowsException()
    {
        var getUsers = async () => await Client.GetUsers();

        await getUsers.Should().ThrowAsync<InvalidOperationException>();
    }

    [Test]
    public async Task GetUsers()
    {
        object[] users = await Client.GetUsers(8331546);

        users.Should().ContainSingle();
    }
}
