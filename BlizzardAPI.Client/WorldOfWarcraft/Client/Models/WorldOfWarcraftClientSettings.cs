using BlizzardAPI.Client.BattleNet.Model;

namespace BlizzardAPI.Client.WorldOfWarcraft.Client.Models
{
    public class WorldOfWarcraftClientSettings
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Region { get; set; }
        public string Locale { get; set; }
        internal BattleNetToken Token { get; set; }
    }
}