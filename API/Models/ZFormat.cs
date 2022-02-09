using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{ 
    public class ZFormat
    {
    
        public int Id{ get; set; }
        public int ProductSKU { get; set; }    
        public string ProductName { get; set; }
        public string Product_type { get; set; }
        public bool Graphic { get; set; }
        public string ColorInHex { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Weight { set; get; }
    }
}
