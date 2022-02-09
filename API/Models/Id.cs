using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Datum
    {
        public int ID { get; set; }
    }

    public class RootId
    {
        public List<Datum> Data { set; get; }
    }

}
