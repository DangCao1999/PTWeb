using PTWeb.Areas.Identity.Data;
using System;
using System.Collections.Generic;

#nullable disable

namespace PTWeb.Models
{
    public partial class Order
    {
        public Order()
        {
           
        }

        public int Id { get; set; }
        public byte[] OrderDate { get; set; }
        public long Total { get; set; }
        public string Status { get; set; }
        public string ShipAddress { get; set; }
        public string Phone { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
