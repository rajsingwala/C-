using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using API.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace API
{
    public class ProductId
    {
        public const string BASE_URL = "https://stores.inksoft.com/";
        public const string ID_ENDPOINT = "demo/Api2/GetProductBaseList";
        public static async Task PopulateIdAsync(ObservableCollection<Datum> IdCollection)
        {

            var CallIds = await GetAsync();
            var ids = CallIds.Data;

            foreach (var id in ids)
            {
                IdCollection.Add(id);
            }

        }
        public static async Task<RootId> GetAsync()
        {
            using(var http = new HttpClient())
            {

                var res = await http.GetAsync(BASE_URL + ID_ENDPOINT);
                var result = await res.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<RootId>(result);

                return data;
            }
        }
    }
}
