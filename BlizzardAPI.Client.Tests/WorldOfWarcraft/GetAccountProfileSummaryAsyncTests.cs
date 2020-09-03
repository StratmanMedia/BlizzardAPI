using BlizzardAPI.Client.WorldOfWarcraft.Clients;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.WorldOfWarcraft
{
    [TestClass]
    public class GetAccountProfileSummaryAsyncTests : BaseTest
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
            var profile = wowClient.Accounts.GetAccountProfileSummaryAsync("USN5wAdebpB8KOgXj3r1pvCnA4BATO7yGY").GetAwaiter().GetResult();
            Assert.AreEqual(profile.Id, 523559);
        }
    }
}