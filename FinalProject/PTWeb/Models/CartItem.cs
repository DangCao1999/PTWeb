using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTWeb.Models
{
    public class CartItem
    {
        public Product Product;
        public int Quantity { get; set; }
        public double Price => Quantity * Product.Price;
    }
}
