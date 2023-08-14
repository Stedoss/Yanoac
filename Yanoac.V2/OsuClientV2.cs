using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Yanoac.Client;
using Yanoac.Client.Models;
using Yanoac.V2.Models.Authentication;
using Yanoac.V2.Requests;
using Yanoac.V2.Responses;

namespace Yanoac.V2
{
    public partial class OsuClientV2 : OsuClient
    {
        public OsuClientV2(OsuClientV2Settings? clientSettings = null, HttpClient? httpClient = null)
            : base(httpClient ?? new HttpClient())
        {
            Settings = clientSettings ?? new OsuClientV2Settings();
        }

        private OsuClientV2Settings settings;

        public OsuClientV2Settings Settings
        {
            get => settings;
            set
            {
                Client.BaseAddress = new Uri(value.BaseUrl);

                settings = value;
            }
        }

        public bool IsAuthenticated => !string.IsNullOrWhiteSpace(accessToken?.Token);

        private IAccessToken? accessToken;

        public async Task Authorise()
        {
            var request = new ClientCredentialsGrantRequest
            {
                ClientId = Settings.ClientId,
                ClientSecret = Settings.ClientSecret
            };

            var response = await Post<ClientCredentialsGrantResponse>(request);

            setAccessToken(response.ToAccessToken());
        }

        public async Task Authorise(string callbackUri)
        {
            using var listener = new HttpListener();
            listener.Prefixes.Add(callbackUri);
            listener.Start();

            var authorizationCodeGrantRequest = new AuthorizationCodeGrantRequest
            {
                ClientId = Settings.ClientId,
                RedirectUri = callbackUri
            };

            Process.Start(new ProcessStartInfo
            {
                FileName = authorizationCodeGrantRequest.QueryString,
                UseShellExecute = true
            });

            // Listener blocking starts here
            var listenerContext = await listener.GetContextAsync();
            var listenerRequest = listenerContext.Request;

            string[] codeSplit = listenerRequest.RawUrl.Split(new[] { "code=" }, StringSplitOptions.None);

            if (codeSplit.Length < 2)
                throw new Exception();

            string code = codeSplit[1];

            var tokenRequest = new AuthorizationCodeGrantTokenRequest
            {
                Code = code,
                ClientId = Settings.ClientId,
                ClientSecret = Settings.ClientSecret,
                RedirectUri = callbackUri
            };

            var tokenResponse = await Post<AuthorizationCodeGrantTokenResponse>(tokenRequest);

            setAccessToken(tokenResponse.ToAccessToken());
        }

        protected override async Task<FetchResponse> Fetch(IRequest request)
        {
            var fetchResponse = await base.Fetch(request);

            if (fetchResponse.StatusCode != HttpStatusCode.Unauthorized)
                return fetchResponse;

            // The access token may have expired, try authenticating again and re-run the request.
            await refreshAuthorisation();

            return await base.Fetch(request);
        }

        private async Task refreshAuthorisation()
        {
            if (accessToken is not AuthorizationCodeAccessToken authCodeAccessToken || authCodeAccessToken.Token is null)
                throw new InvalidOperationException("Unable to refresh authorisation as no refresh token was found");

            var request = new AuthorizationCodeGrantRefreshTokenRequest
            {
                ClientId = Settings.ClientId,
                ClientSecret = Settings.ClientSecret,
                RefreshToken = authCodeAccessToken.RefreshToken,
            };

            var tokenResponse = await Post<AuthorizationCodeGrantTokenResponse>(request);

            setAccessToken(tokenResponse.ToAccessToken());
        }

        private void setAccessToken(IAccessToken? token)
        {
            if (token is not null)
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);

            accessToken = token;
        }
    }
}
