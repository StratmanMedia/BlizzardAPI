using System.Threading.Tasks;
using BlizzardAPI.Client.BattleNet.Model;
using BlizzardAPI.Client.Shared.Clients;
using BlizzardAPI.Client.Shared.Services;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Guilds.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Realms.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Shared.Extensions;
using BlizzardAPI.Client.WorldOfWarcraft.Shared.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients
{
    public class InternalGuildClient
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

        internal async Task<Guild> GetGuildAsync(string realmSlug, string guildSlug)
        {
            var uri = $"{_baseUrl}/data/wow/guild/{realmSlug}/{guildSlug}?namespace=profile-{_region}&locale={_locale}&access_token={_token.AccessToken}";
            var restClient = new RestClient();
            var response = await restClient.GetAsync<GuildApiResponse>(uri);
            var slug = response._links.self.href.ParseGuildSlug();
            var guild = new Guild
            {
                Id = response.id,
                Name = response.name,
                Slug = slug,
                Realm = new Realm
                {
                    Id = response.realm.id,
                    Name = response.realm.name,
                    Slug = response.realm.slug
                },
                Faction = response.faction.type,
                AchievementPoints = response.achievement_points,
                MemberCount = response.member_count,
                CreatedTimestamp = response.created_timestamp
            };
            return guild;
        }
    }
}