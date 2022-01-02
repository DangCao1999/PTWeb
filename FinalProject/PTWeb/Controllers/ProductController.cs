using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTWeb.Controllers
{
    public class ProductController : Controller
    {

        private readonly PTWebContext _context;
        public ProductController(PTWebContext pTWebContext)
        {
            this._context = pTWebContext;
        }

        public IActionResult Index(int? id)
        {
            //Console.WriteLine(id);
            Product product = this._context.Products.Where(p => p.Id == id).First();
            return View(product);
        }

        public IActionResult Category(int? id)
        {
            if(id == -1)
            {
                List<Product> products1 = this._context.Products.ToList();
                return View(products1);
            }
            List<Product> products = this._context.Products.Where(p => p.CategoryId == id).ToList();
            return View(products);
        }

        public IActionResult Search(string q)
        {
            List<Product> products = this._context.Products.Where(p => p.Name.Contains(q)).ToList();
            return View(products);
        }
    }
}
