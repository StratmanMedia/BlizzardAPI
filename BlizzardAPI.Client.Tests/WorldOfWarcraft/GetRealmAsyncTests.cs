﻿using System.Collections.Generic;
using System.Linq;
using BlizzardAPI.Client.WorldOfWarcraft.Clients;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardAPI.Client.Tests.WorldOfWarcraft
{
    [TestClass]
    public class GetRealmAsyncTests : BaseTest
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

            var assertions = new List<bool>
            {
                realm.id == 60,
                realm.name == "Stormrage",
                realm.slug == "stormrage"
            };
            Assert.IsTrue(assertions.All(a => a));
        }
    }
}