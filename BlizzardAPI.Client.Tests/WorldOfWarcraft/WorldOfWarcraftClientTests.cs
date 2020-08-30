using System;
using BlizzardAPI.Client.BattleNet.Model;
using BlizzardAPI.Client.WorldOfWarcraft.Client;
using BlizzardAPI.Client.WorldOfWarcraft.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.WorldOfWarcraft
{
    [TestClass]
    public class WorldOfWarcraftClientTests : BaseTest
    {
        [TestMethod]
        public void ShouldPassWithClientInfoAndNoToken()
        {
            var client = new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
            {
                ClientId = Config["ClientId"],
                ClientSecret = Config["ClientSecret"],
                Region = "us",
                Locale = "en_US"
            });
        }

        [TestMethod]
        public void ShouldPassWithTokenAndNoClientInfo()
        {
            var client = new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
            {
                Token = new BattleNetToken
                {
                    AccessToken = "someencryptedstring"
                },
                Region = "us",
                Locale = "en_US"
            });
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoAccessToken()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
                {
                    Token = new BattleNetToken(),
                    Region = "us",
                    Locale = "en_US"
                }));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoClientIdAndNoToken()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
                {
                    ClientSecret = Config["ClientSecret"],
                    Region = "us",
                    Locale = "en_US"
                }));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoClientSecretAndNoToken()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
                {
                    ClientId = Config["ClientId"],
                    Region = "us",
                    Locale = "en_US"
                }));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoRegion()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
                {
                    ClientId = Config["ClientId"],
                    ClientSecret = Config["ClientSecret"],
                    Locale = "en_US"
                }));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenNoLocale()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new WorldOfWarcraftClient(new WorldOfWarcraftClientSettings
                {
                    ClientId = Config["ClientId"],
                    ClientSecret = Config["ClientSecret"],
                    Region = "us"
                }));
        }
    }
}