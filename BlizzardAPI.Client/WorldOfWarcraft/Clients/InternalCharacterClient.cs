using System.Threading.Tasks;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Services;
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

        internal async Task<CharacterProfileSummaryApiResponse> GetCharacterProfileSummaryAsync(string realmSlug, string characterName)
        {
            var uri = $"{_baseUrl}/profile/wow/character/{realmSlug}/{characterName.ToLower()}?namespace=profile-{_region}&locale={_locale}";
            var restClient = new RestClient();
            var response = await restClient.GetAsync<CharacterProfileSummaryApiResponse>(uri);
            return response;
        }

        internal async Task<ProtectedCharacterProfileSummaryApiResponse> GetProtectedCharacterProfileSummaryAsync(int realmId, long characterId, string accessToken)
        {
            var uri = $"{_baseUrl}/profile/user/wow/protected-character/{realmId}-{characterId}?namespace=profile-{_region}&locale={_locale}&access_token={accessToken}";
            var restClient = new RestClient();
            var character = await restClient.GetAsync<ProtectedCharacterProfileSummaryApiResponse>(uri);
            return character;
        }

        internal async Task<CharacterMediaApiReponse> GetCharacterMediaAsync(string realmSlug, string characterName)
        {
            var uri = $"{_baseUrl}/profile/wow/character/{realmSlug}/{characterName.ToLower()}/character-media?namespace=profile-{_region}&locale={_locale}";
            var restClient = new RestClient();
            var response = await restClient.GetAsync<CharacterMediaApiReponse>(uri);
            return response;
        }
    }
}