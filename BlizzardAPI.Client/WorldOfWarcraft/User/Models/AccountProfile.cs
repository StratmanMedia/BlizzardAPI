using System.Linq;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.User.Models
{
    public class AccountProfile
    {
        public long Id { get; set; }
        public WowAccount[] WowAccounts { get; set; }

        public AccountProfile(AccountProfileSummaryApiResponse response)
        {
            Id = response.id;
            WowAccounts = response.wow_accounts.Select(a => new WowAccount(a)).ToArray();
        }
    }
}