using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTWeb.Controllers
{
    public class OrderController : Controller
    {
        public const string CARTKEY = "cart";
        private IdentityDBContext _context;
        public OrderController(IdentityDBContext context)
        {
            _context = context;
        }

        //View
        public IActionResult Index()
        {
            return View();
        }

        //Logic

        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
                return NotFound("Product not exist");

            var order = GetOrderDetails();
            var ordersDetail = order.Find(p => p.Product.Id == id);
            if(ordersDetail != null)
            {
                ordersDetail.Quantity++;
            }
            else
            {
                order.Add(new OrderDetail() { Quantity = 1, Product = product, ProductId = id });
            }

            SaveCartSession(order);
            return Ok();
        }

        //Session
        List<OrderDetail> GetOrderDetails()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<OrderDetail>>(jsoncart);
            }
            return new List<OrderDetail>();
        }

        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        void SaveCartSession(List<OrderDetail> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
    }
}
