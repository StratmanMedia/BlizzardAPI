using System.Collections.Generic;
using System.Linq;
using BlizzardAPI.Client.WorldOfWarcraft.Clients;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.WorldOfWarcraft
{
    [TestClass]
    public class GetGuildAsyncTests : BaseTest
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
            var guild = wowClient.Guilds.GetGuildAsync("stormrage", "timeless-endeavour").GetAwaiter().GetResult();

            var assertions = new List<bool>
            {
                guild.Id == 58564441,
                guild.Name == "timeless endeavour",
                guild.Slug == "timeless-endeavour",
                guild.Realm.Slug == "stormrage",
                guild.Faction == "ALLIANCE"
            };
            Assert.IsTrue(assertions.All(a => a));
        }
    }
}