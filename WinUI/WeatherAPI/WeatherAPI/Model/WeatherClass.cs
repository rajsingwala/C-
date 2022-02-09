using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Model
{
    public class Country
    {
        public string ID { get; set; }
        public string LocalizedName { get; set; }
    }

    public class AutoComplete
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public Country Country { get; set; }
        public Country AdministrativeArea { get; set; }
    }


}
