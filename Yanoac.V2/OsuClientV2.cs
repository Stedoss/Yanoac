using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Yanoac.Client;
using Yanoac.V2.Models;
using Yanoac.V2.Requests;
using Yanoac.V2.Responses;

namespace Yanoac.V2
{
    public partial class OsuClientV2 : OsuClient, IOsuClientV2
    {
        public OsuClientV2(OsuClientV2Settings? settings = null, HttpClient? httpClient = null)
            : base(httpClient ?? new HttpClient())
        {
            Settings = settings ?? new OsuClientV2Settings();
        }

        private OsuClientV2Settings _settings;
        
        public OsuClientV2Settings Settings
        {
            get => _settings;
            set
            {
                Client.BaseAddress = new Uri(value.BaseUrl);
                
                _settings = value;
            }
        }

        public bool IsAuthenticated => !string.IsNullOrWhiteSpace(AccessToken?.Token);
        
        private AccessToken? _accessToken;

        private AccessToken? AccessToken
        {
            get => _accessToken;
            set
            {
                if (value is not null)
                    Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", value.Token);

                _accessToken = value;
            }
        }

        public async Task Authorise()
        {
            var request = new ClientCredentialsGrantRequest
            {
                ClientId = Settings.ClientId,
                ClientSecret = Settings.ClientSecret
            };

            var response = await Post<ClientCredentialsGrantResponse>(request);

            AccessToken = response.ToAccessToken();
        }

        public async Task Authorise(string callbackUrl)
        {
            using var listener =  new HttpListener();
            listener.Prefixes.Add(callbackUrl);
            listener.Start();

            var authorizationCodeGrantRequest = new AuthorizationCodeGrantRequest
            {
                ClientId = Settings.ClientId,
                RedirectUri = callbackUrl
            };
            
            Process.Start(new ProcessStartInfo
            {
                FileName = authorizationCodeGrantRequest.QueryString,
                UseShellExecute = true
            });

            // Listener blocking starts here
            var listenerContext = await listener.GetContextAsync();
            var listenerRequest = listenerContext.Request;

            var codeSplit = listenerRequest.RawUrl.Split(new[] {"code="}, StringSplitOptions.None);

            if (codeSplit.Length < 2)
                throw new Exception();

            var code = codeSplit[1];

            var tokenRequest = new AuthorizationCodeGrantTokenRequest
            {
                Code = code,
                ClientId = Settings.ClientId,
                ClientSecret = Settings.ClientSecret,
                RedirectUri = callbackUrl
            };

            var tokenResponse = await Post<ClientCredentialsGrantResponse>(tokenRequest);

            AccessToken = tokenResponse.ToAccessToken();
        }
    }
}