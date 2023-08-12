using System.Threading.Tasks;

namespace Yanoac.V2
{
    public interface IOsuClientV2
    {
        public Task Authorise();
        public Task Authorise(string callbackUrl);
    }
}