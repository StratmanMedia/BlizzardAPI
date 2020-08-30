using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BlizzardAPI.Client.BattleNet.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlizzardAPI.Client.BattleNet.Clients
{
    internal class TokenClient
    {
        private readonly TokenClientSettings _clientSettings;
        private readonly HttpClient _http;

        internal TokenClient(TokenClientSettings settings)
        {
            _clientSettings = settings;
            _http = new HttpClient();
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{_clientSettings.ClientId}:{_clientSettings.ClientSecret}")));
        }

        internal async Task<BattleNetToken> GetClientCredentialsTokenAsync()
        {
            var bodyDictionary = new Dictionary<string, string>
            {
                {"grant_type", "client_credentials"},
                {"scope", _clientSettings.Scope}
            };
            var body = new FormUrlEncodedContent(bodyDictionary);
            var token = await SendTokenRequest(body);
            return token;
        }

        internal async Task<BattleNetToken> GetAccessTokenAsync(string authCode, string redirectUri)
        {
            var bodyDictionary = new Dictionary<string, string>
            {
                {"code", authCode},
                {"grant_type", "authorization_code"},
                {"redirect_uri", redirectUri},
                {"scope", _clientSettings.Scope}
            };
            var body = new FormUrlEncodedContent(bodyDictionary);
            var token = await SendTokenRequest(body);
            return token;
        }

        private async Task<BattleNetToken> SendTokenRequest(FormUrlEncodedContent body)
        {
            var response = await _http.PostAsync("https://us.battle.net/oauth/token", body);

            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            var jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy { ProcessDictionaryKeys = true }
                },
                Formatting = Formatting.Indented
            };
            var token = JsonConvert.DeserializeObject<BattleNetToken>(json, jsonSettings);
            return token;
        }
    }
}
