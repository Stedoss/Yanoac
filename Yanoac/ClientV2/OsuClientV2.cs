using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Yanoac.ClientV2.Fragments;
using Yanoac.ClientV2.Models;
using Yanoac.ClientV2.Requests;
using Yanoac.ClientV2.Responses;

namespace Yanoac.ClientV2
{
    public class OsuClientV2 : IOsuClientV2
    {
        public OsuClientV2()
        {
            Settings = new OsuClientV2Settings();

            Beatmaps = new BeatmapsFragment(Client, Settings);
        }

        private HttpClient Client { get; } = new();

        public OsuClientV2Settings Settings { get; set; }

        public BeatmapsFragment Beatmaps { get; }

        public bool IsAuthenticated => !string.IsNullOrWhiteSpace(AccessToken?.Token);
        
        private AccessToken? AccessToken { get; set; }
        
        public async Task Authorise()
        {
            var request = new ClientCredentialsGrantRequest
            {
                ClientId = Settings.ClientId,
                ClientSecret = Settings.ClientSecret
            };

            var response = await post<ClientCredentialsGrantResponse>(request);

            AccessToken = response.ToAccessToken();

            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken.Token);
        }

        private async Task<T> post<T>(IRequest request)
        {
            var url = request is ClientCredentialsGrantRequest ? $"{request.Endpoint}" : $"{Settings.BaseUrl}{request.Endpoint}";
            
            var resp = await Client.PostAsync(url,
                new StringContent(JsonSerializer.Serialize(request as object), Encoding.UTF8, "application/json"));
            var responseContent = resp.Content;

            var objectResponse = await JsonSerializer.DeserializeAsync<T>(await responseContent.ReadAsStreamAsync());

            return objectResponse ?? throw new Exception();
        }
    }
}