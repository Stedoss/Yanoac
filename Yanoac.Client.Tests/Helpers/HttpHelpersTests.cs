using NUnit.Framework;
using Yanoac.Client.Helpers;

namespace Yanoac.Client.Tests.Helpers;

[TestFixture]
public class HttpHelpersTests
{
    [TestCase("ids", new[] { "1", "2", "3" }, "ids[]=1&ids[]=2&ids[]=3")]
    [TestCase("ids", new[] { "one", "two", "three" }, "ids[]=one&ids[]=two&ids[]=three")]
    [TestCase("ids", new[] { "one" }, "ids[]=one")]
    [TestCase("ids", new string[] { }, "")]
    public void EnumerableToUrlParams(string paramName, string[] parameters, string expected)
    {
        string urlParams = HttpHelpers.EnumerableToUrlParams(paramName, parameters);

        Assert.That(urlParams, Is.EqualTo(expected));
    }
}
