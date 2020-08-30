using System.Threading.Tasks;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Realms.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Realms
{
    internal class RealmsClient
    {
        private readonly RealmsClientSettings _clientSettings;
        private readonly RestClient _restClient;

        internal RealmsClient(RealmsClientSettings settings)
        {
            _clientSettings = settings;
            _restClient = new RestClient(new RestClientSettings
            {
                Token = _clientSettings.Token
            });
        }

        internal async Task<Realm> GetRealmAsync(string realmName)
        {
            var uri = $"https://{_clientSettings.Region}.api.blizzard.com/data/wow/realm/{realmName}?namespace=dynamic-{_clientSettings.Region}&locale={_clientSettings.Locale}";
            var realm = await _restClient.GetAsync<Realm>(uri);
            return realm;
        }
    }
}
