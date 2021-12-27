using System;
using System.Collections.Generic;

#nullable disable

namespace PTWeb.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
