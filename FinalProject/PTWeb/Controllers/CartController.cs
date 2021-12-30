using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace PTWeb.Controllers
{
    public class CartController : Controller
    {

        public const string CARTKEY = "cart";
        private IdentityDBContext _context;
        public CartController(IdentityDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CartItem> cart = GetCartDetails();
            ViewData["cart"] = cart;
            return View();
        }



        [HttpGet]
        public IActionResult GetCart()
        {
            List<CartItem> cart = GetCartDetails();
            var obj = JsonConvert.SerializeObject(cart);
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult AddToCart(int id)
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
                cart.Add(new CartItem() { Quantity = 1, Product = product });
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
            if(cartDetail != null)
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
        //Session
        List<CartItem> GetCartDetails()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
    }
}
