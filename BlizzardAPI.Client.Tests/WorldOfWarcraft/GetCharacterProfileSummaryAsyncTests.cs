using System.Collections.Generic;
using System.Linq;
using BlizzardAPI.Client.WorldOfWarcraft.Clients;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.WorldOfWarcraft
{
    [TestClass]
    public class GetCharacterProfileSummaryAsyncTests : BaseTest
    {
        [TestMethod]
        public void ShouldPass()
        {
            var wowClient = new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
            {
                ClientId = Config["ClientId"],
                ClientSecret = Config["ClientSecret"],
                Region = "us",
                Locale = "en_US"
            });
            var character = wowClient.Characters.GetCharacterProfileSummaryAsync("stormrage", "maestero").GetAwaiter().GetResult();

            var assertions = new List<bool>
            {
                character.Id == 211745922,
                character.Name == "Maestero",
                character.Gender == "MALE",
                character.Faction == "ALLIANCE",
                character.Race == "Draenei",
                character.PlayableClass.Name == "Paladin",
                character.Realm.Slug == "stormrage",
                character.Guild.Slug == "timeless-endeavour"
            };
            Assert.IsTrue(assertions.All(a => a));
        }
    }
}
