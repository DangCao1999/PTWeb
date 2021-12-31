using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;


namespace PTWeb.Controllers
{
    public class CartController : Controller
    {

        public const string CARTKEY = "cart";
        private PTWebContext _context;
        private readonly UserManager<User> _userManager;
        public CartController(PTWebContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<CartItem> cart = GetCartDetails();
            ViewData["cart"] = cart;
            return View();
        }

        public async Task<IActionResult> CheckOut()
        {
            User user = await _userManager.GetUserAsync(this.User);
            List<OrderDetail> orderDetails = getOrderDetail();
            Order order = new Order()
            {
                OrderDetails = orderDetails,
                Users = user,
                ShipAddress = user.Address,
                Phone = user.Phone,
                Total = orderDetails.Sum(e => e.Price),
            };
            //ViewData["order"] = order;
            return View(order);
        }

        [HttpGet]
        public IActionResult GetCartCount()
        {
            int count = 0;
            List<CartItem> cart = GetCartDetails();
            foreach(var cartItem in cart)
            {
                count += cartItem.Quantity;
            }
            return Ok(count);
        }


        [HttpGet]
        public IActionResult GetCart()
        {
            List<CartItem> cart = GetCartDetails();
            var obj = JsonConvert.SerializeObject(cart);
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult AddToCart(int id, int quantity = 1)
        {
            var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
                return NotFound("Product not exist");

            var cart = GetCartDetails();
            var cartDetail = cart.Find(p => p.Product.Id == id);
            if (cartDetail != null)
            {
                cartDetail.Quantity++;
            }
            else
            {
                cart.Add(new CartItem() { Quantity = quantity, Product = product });
            }

            SaveCartSession(cart);
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveCartItem(int id)
        {
            var product = _context.Products.Where(p => p.Id != id).FirstOrDefault();
            if (product == null) return NotFound("Product not exist");
            var cart = GetCartDetails();
            var cartDetail = cart.Find(p => p.Product.Id == id);
            if (cartDetail != null)
            {
                cart.Remove(cartDetail);
            }
            else
            {
                return NotFound("Product not in your cart");
            }
            SaveCartSession(cart);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCartItem(int id, int Quantity)
        {
            var product = _context.Products.Where(p => p.Id != id).FirstOrDefault();
            if (product == null) return NotFound("Product not exist");
            var cart = GetCartDetails();
            var cartDetail = cart.Find(p => p.Product.Id == id);
            if (cartDetail == null) return NotFound("Product not in your cart");
            cartDetail.Quantity = Quantity;
            SaveCartSession(cart);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Pay()
        {
            User user = await _userManager.GetUserAsync(this.User);
            List<OrderDetail> orderDetails = getOrderDetail();
            orderDetails.ForEach(e =>
            {
                e.ProductId = e.Product.Id;
                e.Product = null;
            });
            Order order = new Order()
            {
                OrderDate = DateTime.Now,
                OrderDetails = orderDetails,
                UserId = user.Id,
                ShipAddress = user.Address,
                Phone = user.Phone,
                Total = orderDetails.Sum(e => e.Price),
            };
            _context.Orders.Add(order);
            var check = _context.SaveChanges();
            if (check != 0)
            {
                ClearCart();
            }
            return Ok();
            
        }
        //Session
        private List<CartItem> GetCartDetails()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        private void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        private void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        private List<OrderDetail> getOrderDetail()
        {
            List<CartItem> cartItems = GetCartDetails();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            cartItems.ForEach(e =>
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Price = Convert.ToInt64(e.Price),
                    Product = e.Product,
                    Quantity = e.Quantity,
                };
                orderDetails.Add(orderDetail);
            });
            return orderDetails;
        }

    }
}
