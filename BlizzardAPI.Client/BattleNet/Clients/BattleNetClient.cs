using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BlizzardAPI.Client.BattleNet.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlizzardAPI.Client.BattleNet.Clients
{
    public class BattleNetClient
    {
        private readonly BattleNetClientSettings _clientSettings;
        private readonly TokenClient _tokenClient;
        private readonly HttpClient _http;

        public BattleNetClient(BattleNetClientSettings settings)
        {
            _clientSettings = settings ?? throw new ArgumentException("BattleNetClient settings must be provided.");
            if (string.IsNullOrWhiteSpace(_clientSettings.ClientId) || string.IsNullOrWhiteSpace(_clientSettings.ClientSecret))
                throw new ArgumentException("Client ID and Client Secret must be provided.");
            if (string.IsNullOrWhiteSpace(_clientSettings.Scope))
                throw new ArgumentException("Scope must be provided.");
            if (string.IsNullOrWhiteSpace(_clientSettings.Region))
                throw new ArgumentException("Region must be provided.");

            _tokenClient = new TokenClient(new TokenClientSettings
            {
                ClientId = _clientSettings.ClientId,
                ClientSecret = _clientSettings.ClientSecret,
                Scope = _clientSettings.Scope,
                Region = _clientSettings.Region
            });
            _http = new HttpClient();
        }

        public async Task<BattleNetToken> ClientCredentialsTokenRequest()
        {
            var token = await _tokenClient.GetClientCredentialsTokenAsync();
            return token;
        }

        public async Task<BattleNetToken> UserAccessTokenRequest(string authCode, string redirectUri)
        {
            var token = await _tokenClient.GetAccessTokenAsync(authCode, redirectUri);
            return token;
        }

        public async Task<BattleNetUserInfo> UserInfoRequest(string accessToken)
        {
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var response = await _http.GetAsync($"https://{_clientSettings.Region}.battle.net/oauth/userinfo");
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
            var userInfo = JsonConvert.DeserializeObject<BattleNetUserInfo>(json, jsonSettings);
            return userInfo;
        }
    }
}