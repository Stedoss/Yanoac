namespace Yanoac.ClientV2;

public class OsuClientV2Settings
{
    public virtual string BaseUrl => "https://osu.ppy.sh/api/v2/";
    
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
}