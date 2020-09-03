using BlizzardAPI.Client.BattleNet.Model;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    public class WorldOfWarcraftClientSettings
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Region { get; set; }
        public string Locale { get; set; }
        public BattleNetToken Token { get; set; }
    }
}