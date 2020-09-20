using System.Linq;
using BlizzardAPI.Client.WorldOfWarcraft.Characters.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.User.Models
{
    public class WowAccount
    {
        public long Id { get; set; }
        public Character[] Characters { get; set; }

        internal WowAccount(AccountProfileSummaryApiResponse.WowAccount response)
        {
            Id = response.id;
            Characters = response.characters.Select(c => new Character(c)).ToArray();
        }
    }
}