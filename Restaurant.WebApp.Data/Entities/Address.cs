using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data
{
    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }
}
