using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Yanoac.ClientV2.Requests;

namespace Yanoac;

internal class RequestClient
{
    public static readonly HttpClient Client = new();
}