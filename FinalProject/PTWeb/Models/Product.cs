using System;
using System.Collections.Generic;

#nullable disable

namespace PTWeb.Models
{
    public partial class Product
    {
        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public long? PromotionPrice { get; set; }

        public int CategoryId { get; set; }
        public  Category Category { get; set; }
        public  List<OrderDetail> OrderDetails { get; set; }
    }
}
