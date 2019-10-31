using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Product
    {
        //properties of the product model, referenced by Product.Name, etc. Matches DB columns.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }
    }
}
