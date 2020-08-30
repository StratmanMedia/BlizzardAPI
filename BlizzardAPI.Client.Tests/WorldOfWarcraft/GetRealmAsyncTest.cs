using BlizzardAPI.Client.WorldOfWarcraft.Client;
using BlizzardAPI.Client.WorldOfWarcraft.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.WorldOfWarcraft
{
    [TestClass]
    public class GetRealmAsyncTest : BaseTest
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
            var realm = wowClient.Realms.GetRealmAsync("stormrage").GetAwaiter().GetResult();
            Assert.AreEqual(realm.Slug, "stormrage");
        }
    }
}