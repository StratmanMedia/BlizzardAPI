﻿using System.Threading.Tasks;
using BlizzardAPI.Client.BattleNet.Clients;
using BlizzardAPI.Client.BattleNet.Model;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Characters.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Client.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Realms;
using BlizzardAPI.Client.WorldOfWarcraft.Realms.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Client
{
    public class WorldOfWarcraftClient
    {
        private readonly WorldOfWarcraftClientSettings _clientSettings;
        private readonly TokenClient _tokenClient;
        private readonly RestClient _restClient;
        private readonly string _apiBaseUrl;
        public CharactersClient Characters;
        public PublicRealmsClient Realms;

        public WorldOfWarcraftClient(WorldOfWarcraftClientSettings settings)
        {
            _clientSettings = settings;
            _tokenClient = new TokenClient(new TokenClientSettings
            {
                ClientId = _clientSettings.ClientId,
                ClientSecret = _clientSettings.ClientSecret,
                Scope = "wow.profile"
            });
            _clientSettings.Token = _tokenClient.GetClientCredentialsTokenAsync().GetAwaiter().GetResult();
            _restClient = new RestClient(new RestClientSettings
            {
                Token = _clientSettings.Token,
            });
            _apiBaseUrl = $"https://{_clientSettings.Region}.api.blizzard.com";
            Characters = new CharactersClient(this);
            Realms = new PublicRealmsClient(this);
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

            public async Task<Character> GetProtectedCharacterProfileSummaryAsync(string realmId, string characterId)
            {
                var uri = $"{_parent._apiBaseUrl}/profile/wow/protected-character/{realmId}-{characterId}?namespace=profile-{_parent._clientSettings.Region}&locale={_parent._clientSettings.Locale}";
                var character = await _parent._restClient.GetAsync<Character>(uri);
                return character;
            }
        }

        public class PublicRealmsClient
        {
            private readonly WorldOfWarcraftClient _parent;
            private readonly RealmsClient _realmsClient;

            public PublicRealmsClient(WorldOfWarcraftClient parent)
            {
                _parent = parent;
                _realmsClient = new RealmsClient(new RealmsClientSettings
                {
                    Token = _parent._clientSettings.Token,
                    Region = _parent._clientSettings.Region,
                    Locale = _parent._clientSettings.Locale
                });
            }

            public async Task<Realm> GetRealmAsync(string realmName)
            {
                return await _realmsClient.GetRealmAsync(realmName);
            }
        }
    }
}