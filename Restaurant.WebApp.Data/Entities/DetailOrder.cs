using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data.Entities
{
    public class DetailOrder
    {
        public int IdDetailOrder { get; set; }

        public int IdOrder { get; set; }

        public int IdProduct { get; set; }

        public int Quantity { get; set; }

        public string? Observations { get; set; }

        //public virtual Order IdOrderNavigation { get; set; } = null!;

        public virtual Product IdProductNavigation { get; set; } = null!;
    }
}
