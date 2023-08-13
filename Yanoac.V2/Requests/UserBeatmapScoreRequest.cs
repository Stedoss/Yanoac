using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class UserBeatmapScoreRequest : IRequest
{
    public string Endpoint => "beatmaps/{0}/scores/users/{1}";
    public string QueryString => string.Format(Endpoint, BeatmapId, UserId);
    
    public int BeatmapId { get; set; }
    public int UserId { get; set; }
}