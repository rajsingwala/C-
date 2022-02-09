using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.Model;

namespace WeatherAPI.ViewModel.Helpers
{
    public class WeatherHelpers
    {
        public const string BASE_URL = "http://dataservice.accuweather.com/";
        public const string AUTOCOMPLETE_ENDPOINT = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
        public const string CURRENT_CONDITION_ENDPOINT = "currentconditions/v1/{0}?apikey={1}";
        public const string API_KEY = "qCgbgFKOL20oVcnAUbwpQEZvhk0iXitg";

        public static async Task<List<AutoComplete>> GetAutoComplete(string query)
        {
            List<AutoComplete> cities = new List<AutoComplete>();

            string url = BASE_URL + string.Format(AUTOCOMPLETE_ENDPOINT,API_KEY,query);
            
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                cities = JsonConvert.DeserializeObject<List<AutoComplete>>(json);
            }

            return cities;
        }

        public static async Task<CurrentCondition> GetCondition(string key)
        {
            CurrentCondition condition = new CurrentCondition();

            string url = BASE_URL + string.Format(CURRENT_CONDITION_ENDPOINT, key, API_KEY);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                condition = (JsonConvert.DeserializeObject<List<CurrentCondition>>(json)).FirstOrDefault();
            }

            return condition;
        }
    }
}
