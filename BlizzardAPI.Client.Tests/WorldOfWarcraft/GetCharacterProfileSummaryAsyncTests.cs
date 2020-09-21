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
                character.id == 211745922,
                character.name == "Maestero",
                character.gender.type == "MALE",
                character.faction.type == "ALLIANCE",
                character.race.name == "Draenei",
                character.character_class.name == "Paladin",
                character.realm.slug == "stormrage"
            };
            Assert.IsTrue(assertions.All(a => a));
        }
    }
}
