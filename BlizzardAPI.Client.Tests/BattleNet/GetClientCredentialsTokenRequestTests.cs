using BlizzardAPI.Client.BattleNet.Clients;
using BlizzardAPI.Client.BattleNet.Model;
using BlizzardAPI.Client.WorldOfWarcraft.Clients;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.BattleNet
{
    [TestClass]
    public class GetClientCredentialsTokenRequestTests : BaseTest
    {
        [TestMethod]
        public void ShouldPass()
        {
            var battleNetClient = new BattleNetClient(new BattleNetClientSettings
            {
                ClientId = Config["ClientId"],
                ClientSecret = Config["ClientSecret"],
                Scope = "wow.profile",
                Region = "us"
            });
            var token = battleNetClient.ClientCredentialsTokenRequest().GetAwaiter().GetResult();

            var wowClient = new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
            {
                Token = token,
                Region = "us",
                Locale = "en_US"
            });
            var realm = wowClient.Realms.GetRealmAsync("stormrage").GetAwaiter().GetResult();
            Assert.AreEqual(realm.slug, "stormrage");
        }
    }
}