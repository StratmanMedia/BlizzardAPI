using BlizzardAPI.Client.BattleNet.Model;

namespace BlizzardAPI.Client.WorldOfWarcraft.Realms.Models
{
    public class RealmsClientSettings
    {
        public BattleNetToken Token { get; set; }
        public string Region { get; set; }
        public string Locale { get; set; }
    }
}