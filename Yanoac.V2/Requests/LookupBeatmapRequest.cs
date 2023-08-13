using System.Web;
using Yanoac.Client;
using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class LookupBeatmapRequest : IRequest
{
    public string Endpoint => "beatmaps/lookup";

    public string? Checksum { get; set; }
    public string? Filename { get; set; }
    public int? Id { get; set; }

    public string QueryString => $"{Endpoint}?{getQueryStringParameters()}";

    private string getQueryStringParameters()
    {
        if (!string.IsNullOrWhiteSpace(Checksum) && !string.IsNullOrWhiteSpace(Filename) &&
            Id <= 0)
            return "";

        var queryString = HttpUtility.ParseQueryString(string.Empty);

        if (!string.IsNullOrWhiteSpace(Checksum))
            queryString.Add("checksum", Checksum);

        if (!string.IsNullOrWhiteSpace(Filename))
            queryString.Add("filename", Filename);
        
        if (Id > 0)
            queryString.Add("id", Id.ToString());

        return queryString.ToString();
    }
}