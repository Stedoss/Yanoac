namespace Yanoac.V2.Models.Authentication;

public class ClientCredentialsAccessToken : IAccessToken
{
    public string Token { get; set; }
    public int ExpiresIn { get; set; }
}
