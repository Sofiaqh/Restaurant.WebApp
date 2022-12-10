using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public virtual ICollection<DetailOrder> DetailOrders { get; } = new List<DetailOrder>();
    }
}
