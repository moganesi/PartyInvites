using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Product
    {
        
        public String Name { get; set; }
        public String  Category { get; set; } 
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }
        
    }
}
