using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment.Models;

namespace Assignment.Models
{
    public class Payload
    {
        public string Text { set; get; }
        public string Language { set; get; }

        public List<Collection> Framework { set; get; }
        public string Val {set;get;}
        public string Date { set; get; }
    }
}
