using System.Collections.Generic;
using System.Text;

namespace Yanoac.Client.Helpers;

public static class HttpHelpers
{
    public static string EnumerableToUrlParams(string paramName, IEnumerable<string> collection)
    {
        var builder = new StringBuilder();

        foreach (string param in collection)
            builder.Append($"{paramName}[]={param}&");

        return builder.ToString().TrimEnd('&');
    }
}
