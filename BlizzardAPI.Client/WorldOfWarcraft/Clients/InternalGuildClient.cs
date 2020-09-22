using System.Threading.Tasks;
using BlizzardAPI.Client.BattleNet.Model;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Services;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients
{
    internal class InternalGuildClient
    {
        private readonly string _baseUrl;
        private readonly string _region;
        private readonly string _locale;
        private readonly BattleNetToken _token;

        internal InternalGuildClient()
        {
            _baseUrl = ConfigurationService.GetBaseUrl();
            _region = ConfigurationService.GetRegion();
            _locale = ConfigurationService.GetLocale();
            _token = ConfigurationService.GetBattleNetToken();
        }

        internal async Task<GuildApiResponse> GetGuildAsync(string realmSlug, string guildSlug)
        {
            if (realmSlug == null || guildSlug == null) return null;

            var uri = $"{_baseUrl}/data/wow/guild/{realmSlug}/{guildSlug}?namespace=profile-{_region}&locale={_locale}&access_token={_token.AccessToken}";
            var restClient = new RestClient();
            var response = await restClient.GetAsync<GuildApiResponse>(uri);
            return response;
        }
    }
}