using System.Collections.Generic;
using System.Linq;
using BlizzardAPI.Client.BattleNet.Clients;
using BlizzardAPI.Client.BattleNet.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.BattleNet
{
    [TestClass]
    public class UserInfoRequestTests : BaseTest
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
            var userInfo = battleNetClient.UserInfoRequest(Config["AccessToken"]).GetAwaiter().GetResult();
            var assertions = new List<bool>
            {
                userInfo.Id == 523559,
                userInfo.Battletag == "jstratman33#1595"
            };
            Assert.IsTrue(assertions.All(a => a));
        }
    }
}