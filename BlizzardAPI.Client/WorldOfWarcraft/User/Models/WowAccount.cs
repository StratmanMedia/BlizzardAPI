using BlizzardAPI.Client.WorldOfWarcraft.Characters.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.User.Models
{
    public class WowAccount
    {
        public long Id { get; set; }
        public Character[] Characters { get; set; }
    }
}