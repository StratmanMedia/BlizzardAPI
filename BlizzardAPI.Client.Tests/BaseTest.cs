using Microsoft.Extensions.Configuration;

namespace BlizzardAPI.Client.Tests
{
    public class BaseTest
    {
        public IConfigurationRoot Config { get; set; }

        public BaseTest()
        {
            Config = new ConfigurationBuilder()
                .AddUserSecrets<Config>()
                .Build();
        }
    }
}