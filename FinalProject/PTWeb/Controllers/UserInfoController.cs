using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PTWeb.Models;
using PTWeb.ViewModels;
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
        public async Task<IActionResult> Index()
        {
            User user = await this._userManager.GetUserAsync(this.User);
            InputRegister input = new InputRegister()
            {
                Email = user.Email,
                Phone = user.Phone,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
            };
            return View(input);
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

        public async Task<IActionResult> OnUpdate (InputRegister input)
        {
            User user = await this._userManager.GetUserAsync(this.User);
            user.Address = input.Address;
            user.Phone = input.Phone;
            user.FirstName = input.FirstName;
            user.LastName = input.LastName;
            _context.Users.Update(user);
            _context.SaveChanges();
            return Ok();
        }
    }
}
