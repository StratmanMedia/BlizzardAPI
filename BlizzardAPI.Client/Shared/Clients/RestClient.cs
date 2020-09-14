using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BlizzardAPI.Client.Shared.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace BlizzardAPI.Client.Shared.Clients
{
    internal class RestClient
    {
        private readonly HttpClient _httpClient;

        internal RestClient()
        {
            if (string.IsNullOrWhiteSpace(ConfigurationService.GetBattleNetToken().AccessToken)) throw new ArgumentException("Token does not exist.");
            
            _httpClient = new HttpClient();
        }

        internal async Task<T> GetAsync<T>(string uri)
        {
            var queryDictionary = HttpUtility.ParseQueryString(uri);
            if (queryDictionary["access_token"] == null)
            {
                uri = $"{uri}&access_token={ConfigurationService.GetBattleNetToken().AccessToken}";
            }
            var response = await _httpClient.GetAsync(uri);
            var json = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<T>(json);
            return model;
        }

        internal async Task<JObject> GetAsync(string uri)
        {
            var queryDictionary = HttpUtility.ParseQueryString(uri);
            if (queryDictionary["access_token"] == null)
            {
                uri = $"{uri}&access_token={ConfigurationService.GetBattleNetToken().AccessToken}";
            }
            var response = await _httpClient.GetAsync(uri);
            var json = await response.Content.ReadAsStringAsync();
            var model = JObject.Parse(json);
            return model;
        }
    }
}
