using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Product
    {
        public Product(bool stock=true)
        {
            this.InStock = stock;
        }
        public String Name { get; set; }
        public String  Category { get; set; } = "aaa";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }

    }
}
