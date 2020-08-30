using System;
using System.Threading.Tasks;
using BlizzardAPI.Client.BattleNet.Model;

namespace BlizzardAPI.Client.BattleNet.Clients
{
    public class BattleNetClient
    {
        private readonly BattleNetClientSettings _clientSettings;
        private readonly TokenClient _tokenClient;

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
        }

        public async Task<BattleNetToken> ClientCredentialsTokenRequest()
        {
            var token = await _tokenClient.GetClientCredentialsTokenAsync();
            return token;
        }

        public async Task<BattleNetToken> UserAccessTokenRequest()
        {
            var token = await _tokenClient.GetAccessTokenAsync(_clientSettings.AuthCode, _clientSettings.RedirectUri);
            return token;
        }
    }
}