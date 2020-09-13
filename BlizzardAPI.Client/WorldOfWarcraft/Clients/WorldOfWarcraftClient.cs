using System;
using System.Threading.Tasks;
using BlizzardAPI.Client.BattleNet.Clients;
using BlizzardAPI.Client.BattleNet.Model;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Services;
using BlizzardAPI.Client.WorldOfWarcraft.Characters.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Guilds.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Realms.Models;
using BlizzardAPI.Client.WorldOfWarcraft.User.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients
{
    public class WorldOfWarcraftClient
    {
        private readonly WorldOfWarcraftClientSettings _clientSettings;
        private readonly TokenClient _tokenClient;
        private readonly RestClient _restClient;
        private readonly string _apiBaseUrl;
        public AccountClient Accounts;
        public CharactersClient Characters;
        public GuildsClient Guilds;
        public RealmsClient Realms;

        public WorldOfWarcraftClient(WorldOfWarcraftClientSettings settings)
        {
            _clientSettings = settings ?? throw new ArgumentException("WorldOfWarcraftClient settings must be provided.");
            if ((string.IsNullOrWhiteSpace(_clientSettings.ClientId) || string.IsNullOrWhiteSpace(_clientSettings.ClientSecret)) && _clientSettings.Token == null)
                throw new ArgumentException("Either the Client ID/Client Secret or the BattleNetToken must be provided.");
            if (string.IsNullOrWhiteSpace(_clientSettings.Locale))
                throw new ArgumentException("Locale must be provided.");
            if (string.IsNullOrWhiteSpace(_clientSettings.Region))
                throw new ArgumentException("Region must be provided.");

            if (settings.Token == null)
            {
                _tokenClient = new TokenClient(new TokenClientSettings
                {
                    ClientId = _clientSettings.ClientId,
                    ClientSecret = _clientSettings.ClientSecret,
                    Scope = "wow.profile",
                    Region = _clientSettings.Region
                });
                _clientSettings.Token = _tokenClient.GetClientCredentialsTokenAsync().GetAwaiter().GetResult();
            }
            _apiBaseUrl = $"https://{_clientSettings.Region}.api.blizzard.com";
            ConfigurationService.StoreSettings(_clientSettings, _apiBaseUrl);
            _restClient = new RestClient();
            Accounts = new AccountClient();
            Characters = new CharactersClient(this);
            Guilds = new GuildsClient();
            Realms = new RealmsClient(this);
        }

        public class AccountClient
        {
            private readonly InternalAccountProfileClient _internalClient = new InternalAccountProfileClient();

            public async Task<AccountProfile> GetAccountProfileSummaryAsync(string accessToken)
            {
                return await _internalClient.GetAccountProfileSummaryAsync(accessToken);
            }
        }

        public class CharactersClient
        {
            private readonly WorldOfWarcraftClient _parent;

            public CharactersClient(WorldOfWarcraftClient parent)
            {
                _parent = parent;
            }

            public async Task<Character> GetCharacterProfileSummaryAsync(string realmSlug, string characterName)
            {
                var uri = $"{_parent._apiBaseUrl}/profile/wow/character/{realmSlug}/{characterName}?namespace=profile-{_parent._clientSettings.Region}&locale={_parent._clientSettings.Locale}";
                var character = await _parent._restClient.GetAsync<Character>(uri);
                return character;
            }

            public async Task<Character> GetProtectedCharacterProfileSummaryAsync(string realmId, string characterId, string accessToken)
            {
                var uri = $"{_parent._apiBaseUrl}/profile/wow/protected-character/{realmId}-{characterId}?namespace=profile-{_parent._clientSettings.Region}&locale={_parent._clientSettings.Locale}&access_token={accessToken}";
                var character = await _parent._restClient.GetAsync<Character>(uri);
                return character;
            }
        }

        public class GuildsClient
        {
            private readonly InternalGuildClient _internalClient = new InternalGuildClient();

            public async Task<Guild> GetGuildAsync(string realmSlug, string guildSlug)
            {
                return await _internalClient.GetGuildAsync(realmSlug, guildSlug);
            }
        }

        public class RealmsClient
        {
            private readonly WorldOfWarcraftClient _parent;

            public RealmsClient(WorldOfWarcraftClient parent)
            {
                _parent = parent;
            }

            public async Task<Realm> GetRealmAsync(string realmSlug)
            {
                var uri = $"{_parent._apiBaseUrl}/data/wow/realm/{realmSlug}?namespace=dynamic-{_parent._clientSettings.Region}&locale={_parent._clientSettings.Locale}";
                var realm = await _parent._restClient.GetAsync<Realm>(uri);
                return realm;
            }
        }
    }
}