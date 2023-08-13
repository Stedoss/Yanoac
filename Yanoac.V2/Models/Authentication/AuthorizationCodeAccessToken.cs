namespace Yanoac.V2.Models.Authentication;

public class AuthorizationCodeAccessToken : IAccessToken
{
    public string Token { get; set; } = null!;
    public int ExpiresIn { get; set; }
    public string RefreshToken { get; set; } = null!;
}
