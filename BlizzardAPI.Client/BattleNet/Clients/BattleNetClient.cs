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
            _clientSettings = settings;
            _tokenClient = new TokenClient(new TokenClientSettings
            {
                ClientId = _clientSettings.ClientId,
                ClientSecret = _clientSettings.ClientSecret,
                Scope = _clientSettings.Scope
            });
        }

        public async Task<BattleNetToken> UserAccessTokenRequest()
        {
            var token = await _tokenClient.GetAccessTokenAsync(_clientSettings.AuthCode, _clientSettings.RedirectUri);
            return token;
        }
    }
}