namespace Yanoac.V2.Models.Authentication;

public interface IAccessToken
{
    public string Token { get; set; }
    public int ExpiresIn { get; set; }
}
