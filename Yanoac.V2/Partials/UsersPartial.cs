using System.Threading.Tasks;
using Yanoac.V2.Requests;

namespace Yanoac.V2;

public partial class OsuClientV2

{
    public async Task<object[]> GetUsers(params long[] ids)
    {
        var request = new GetUsersRequest
        {
            Ids = ids
        };

        var fetchResponse = await Fetch(request);

        return await fetchResponse.ContentAsJson<dynamic>();
    }
}
