using System.Threading.Tasks;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Services;
using BlizzardAPI.Client.WorldOfWarcraft.Characters.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients
{
    internal class InternalCharacterClient
    {
        private readonly string _baseUrl;
        private readonly string _region;
        private readonly string _locale;

        internal InternalCharacterClient()
        {
            _baseUrl = ConfigurationService.GetBaseUrl();
            _region = ConfigurationService.GetRegion();
            _locale = ConfigurationService.GetLocale();
        }

        internal async Task<Character> GetCharacterProfileSummaryAsync(string realmSlug, string characterName)
        {
            var uri = $"{_baseUrl}/profile/wow/character/{realmSlug}/{characterName}?namespace=profile-{_region}&locale={_locale}";
            var restClient = new RestClient();
            var response = await restClient.GetAsync<CharacterProfileSummaryApiResponse>(uri);
            var character = new Character(response);
            return character;
        }

        internal async Task<Character> GetProtectedCharacterProfileSummaryAsync(string realmId, string characterId, string accessToken)
        {
            var uri = $"{_baseUrl}/profile/wow/protected-character/{realmId}-{characterId}?namespace=profile-{_region}&locale={_locale}&access_token={accessToken}";
            var restClient = new RestClient();
            var character = await restClient.GetAsync<Character>(uri);
            return character;
        }
    }
}