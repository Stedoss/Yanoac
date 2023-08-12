﻿using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Yanoac.Client;
using Yanoac.V2.Fragments;
using Yanoac.V2.Models;
using Yanoac.V2.Requests;
using Yanoac.V2.Responses;

namespace Yanoac.V2
{
    public class OsuClientV2 : Fragment, IOsuClientV2
    {
        public OsuClientV2(OsuClientV2Settings? settings = null, OsuHttpClient? httpClient = null)
            : base(httpClient ?? new(), settings ?? new OsuClientV2Settings())
        {
            Settings = settings ?? new OsuClientV2Settings();
            
            
            Beatmaps = new BeatmapsFragment(Client, Settings);
            Scores = new ScoresFragment(Client, Settings);
        }

        private OsuClientV2Settings _settings;

        public OsuClientV2Settings Settings
        {
            get => _settings;
            set
            {
                UnderlyingClient.BaseAddress = new Uri(value.BaseUrl);
                
                _settings = value;
            }
        }

        public BeatmapsFragment Beatmaps { get; }
        public ScoresFragment Scores { get; }

        public bool IsAuthenticated => !string.IsNullOrWhiteSpace(AccessToken?.Token);
        
        private AccessToken? AccessToken { get; set; }

        public async Task Authorise()
        {
            var request = new ClientCredentialsGrantRequest
            {
                ClientId = Settings.ClientId,
                ClientSecret = Settings.ClientSecret
            };

            var response = await Client.Post<ClientCredentialsGrantResponse>(request);

            AccessToken = response.ToAccessToken();

            UnderlyingClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken.Token);
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

            var tokenResponse = await Client.Post<ClientCredentialsGrantResponse>(tokenRequest);

            AccessToken = tokenResponse.ToAccessToken();
            
            UnderlyingClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken.Token);
        }
    }
}