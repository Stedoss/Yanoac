namespace Yanoac.Client;

public interface IRequest
{
    public string Endpoint { get; }
    public string QueryString { get; }
}