using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlizzardAPI.Client.Shared.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlizzardAPI.Client.Shared.Clients
{
    internal class RestClient
    {
        private readonly HttpClient _httpClient;

        internal RestClient(RestClientSettings settings)
        {
            if (string.IsNullOrWhiteSpace(settings.Token.AccessToken)) throw new ArgumentException("Token does not exist.");

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {settings.Token.AccessToken}");
        }

        internal async Task<T> GetAsync<T>(string uri)
        {
            var response = await _httpClient.GetAsync(uri);
            var json = await response.Content.ReadAsStringAsync();
            var jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy { ProcessDictionaryKeys = true }
                },
                Formatting = Formatting.Indented
            };
            var model = JsonConvert.DeserializeObject<T>(json, jsonSettings);
            return model;
        }
    }
}
