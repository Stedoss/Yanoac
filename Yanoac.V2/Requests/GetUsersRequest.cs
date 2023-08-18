using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanoac.Client.Helpers;
using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class GetUsersRequest : IRequest
{
    public string QueryString => $"users?{getQueryStringParameters()}";

    public IEnumerable<long> Ids { get; set; }

    private string getQueryStringParameters()
    {
        string[] idsAsStrings = Ids.Select(id => id.ToString()).ToArray();

        if (!idsAsStrings.Any())
            throw new InvalidOperationException("Ids must not be empty");

        return HttpHelpers.EnumerableToUrlParams("ids", idsAsStrings);
    }
}
