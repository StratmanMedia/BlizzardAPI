using BlizzardAPI.Client.WorldOfWarcraft.Shared.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.User.Models
{
    public class AccountProfile
    {
        public long Id { get; set; }
        public WowAccount[] WowAccounts { get; set; }
        public Resource Collections { get; set; }
    }
}