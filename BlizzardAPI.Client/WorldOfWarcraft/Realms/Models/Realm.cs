using BlizzardAPI.WorldOfWarcraft.Realms.Model;

namespace BlizzardAPI.Client.WorldOfWarcraft.Realms.Models
{
    public class Realm
    {
        public int Id { get; set; }
        public Region Region { get; set; }
        public ConnectedRealm ConnectedRealm { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Locale { get; set; }
        public string Timezone { get; set; }
        public bool IsTournament { get; set; }
        public string Slug { get; set; }
    }
}