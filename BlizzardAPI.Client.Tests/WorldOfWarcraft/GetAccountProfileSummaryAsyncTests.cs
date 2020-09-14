using System.Collections.Generic;
using System.Linq;
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
            var profile = wowClient.Accounts.GetAccountProfileSummaryAsync(Config["AccessToken"]).GetAwaiter().GetResult();

            var assertions = new List<bool>
            {
                profile.Id == 523559,
                profile.WowAccounts.Any(),
                profile.WowAccounts.Any(a => a.Characters.Any())
            };
            Assert.IsTrue(assertions.All(a => a));
        }
    }
}