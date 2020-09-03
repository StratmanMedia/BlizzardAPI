using BlizzardAPI.Client.BattleNet.Model;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;

namespace BlizzardAPI.Client.Shared.Services
{
    internal static class ConfigurationService
    {
        private static WorldOfWarcraftClientSettings _settings;
        private static string _baseUrl;

        internal static void StoreSettings(WorldOfWarcraftClientSettings settings, string baseUrl)
        {
            _settings = new WorldOfWarcraftClientSettings
            {
                ClientId = settings.ClientId,
                ClientSecret = settings.ClientSecret,
                Region = settings.Region,
                Locale = settings.Locale,
                Token = settings.Token
            };
            _baseUrl = baseUrl;
        }

        internal static string GetClientId()
        {
            return _settings.ClientId;
        }

        internal static string GetClientSettings()
        {
            return _settings.ClientSecret;
        }

        internal static string GetRegion()
        {
            return _settings.Region;
        }

        internal static string GetLocale()
        {
            return _settings.Locale;
        }

        internal static BattleNetToken GetBattleNetToken()
        {
            return _settings.Token;
        }

        internal static string GetBaseUrl()
        {
            return _baseUrl;
        }
    }
}