using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data
{
    public class Client
    {
        public int IdClient { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Document { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Adress { get; set; } = string.Empty;
    }
}
