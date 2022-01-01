using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTWeb.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly PTWebContext _context;
        public UserInfoController(UserManager<User> userManager, PTWebContext context)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpdateUser()
        {
            return View();
        }

        public IActionResult History()
        {
            string userId = _userManager.GetUserId(this.User);
            List<Order> orders = _context.Orders.Where(o => o.UserId == userId).ToList();
            Console.WriteLine(orders);
            return View(orders);
        }

        public IActionResult OrderDetail(string Id)
        {
            int OId = Convert.ToInt32(Id);
            List<OrderDetail> orderDetails = _context.OrderDetails.Where(o => o.OrderId == Convert.ToInt16(OId)).ToList();
            orderDetails.ForEach(o =>
            {
                Product product = _context.Products.First(p => p.Id == o.ProductId);
                o.Product = product;
            });
            Order order = this._context.Orders.FirstOrDefault(o => o.Id == OId);
            order.OrderDetails = orderDetails;

            return View(order);
        }
    }
}
