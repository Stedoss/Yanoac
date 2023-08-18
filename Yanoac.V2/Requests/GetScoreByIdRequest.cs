using Yanoac.Client.Models;

namespace Yanoac.V2.Requests;

public class GetScoreByIdRequest : IRequest
{
    public string QueryString => $"scores/{Mode}/{Id}";

    public string Mode { get; set; }
    public long Id { get; set; }
}
