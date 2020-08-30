using BlizzardAPI.Client.WorldOfWarcraft.Client;
using BlizzardAPI.Client.WorldOfWarcraft.Client.Models;
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
            Assert.AreEqual(character.Name, "Maestero");
        }
    }
}
