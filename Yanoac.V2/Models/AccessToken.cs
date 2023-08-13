namespace Yanoac.V2.Models;

public class AccessToken
{
    public string Token { get; set; } = null!;
    public int ExpiresIn { get; set; }
}
