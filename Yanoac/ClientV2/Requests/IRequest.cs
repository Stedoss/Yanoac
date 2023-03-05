using System.Text.Json.Serialization;

namespace Yanoac.ClientV2.Requests;

public interface IRequest
{
    public string Endpoint { get; }
    public string QueryString { get; }
}