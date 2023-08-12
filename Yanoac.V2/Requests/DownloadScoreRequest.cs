using Yanoac.Client;

namespace Yanoac.V2.Requests;

public class DownloadScoreRequest : IRequest
{
    // scores/{mode}/{score}/download
    public string Endpoint => "scores/{0}/{1}/download";
    public string QueryString => string.Format(Endpoint, Mode, Score);
    
    public string Mode { get; set; }
    public string Score { get; set; }
}