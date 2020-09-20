using System.Threading.Tasks;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Services;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using BlizzardAPI.Client.WorldOfWarcraft.User.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients
{
    internal class InternalAccountProfileClient
    {
        private readonly string _baseUrl;
        private readonly string _region;
        private readonly string _locale;

        internal InternalAccountProfileClient()
        {
            _baseUrl = ConfigurationService.GetBaseUrl();
            _region = ConfigurationService.GetRegion();
            _locale = ConfigurationService.GetLocale();
        }

        internal async Task<AccountProfile> GetAccountProfileSummaryAsync(string accessToken)
        {
            var uri = $"{_baseUrl}/profile/user/wow?namespace=profile-{_region}&locale={_locale}&access_token={accessToken}";
            var restClient = new RestClient();
            var response = await restClient.GetAsync<AccountProfileSummaryApiResponse>(uri);
            var profile = new AccountProfile(response);
            return profile;
        }
    }
}