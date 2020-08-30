using System;
using BlizzardAPI.Client.BattleNet.Clients;
using BlizzardAPI.Client.BattleNet.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.BattleNet
{
    [TestClass]
    public class BattleNetClientTests : BaseTest
    {
        [TestMethod]
        public void ShouldThrowExceptionWhenNoClientId()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new BattleNetClient(new BattleNetClientSettings
                {
                    ClientSecret = Config["ClientSecret"],
                    Scope = "wow.profile",
                    Region = "us"
                }));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoClientSecret()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new BattleNetClient(new BattleNetClientSettings
                {
                    ClientId = Config["ClientId"],
                    Scope = "wow.profile",
                    Region = "us"
                }));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoScope()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new BattleNetClient(new BattleNetClientSettings
                {
                    ClientId = Config["ClientId"],
                    ClientSecret = Config["ClientSecret"],
                    Region = "us"
                }));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoRegion()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new BattleNetClient(new BattleNetClientSettings
                {
                    ClientId = Config["ClientId"],
                    ClientSecret = Config["ClientSecret"],
                    Scope = "wow.profile"
                }));
        }
    }
}