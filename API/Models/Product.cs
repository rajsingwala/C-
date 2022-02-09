using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Size
    {
        public double Weight { get; set; }
        public string LongName { get; set; }
    }

    public class Style
    {
        public List<Size> Sizes { get; set; }
        public string HtmlColor1 { get; set; }
        public string Name { get; set; }
    }

    public class Data
    {
        public int ID { get; set; }
        public bool DesignOnline { get; set; }
        public List<Style> Styles { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }

    }

    public class RootProduct
    {
        public Data Data { get; set; }
    }

}
