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

        private readonly IdentityDBContext _context;
        public ProductController(IdentityDBContext pTWebContext)
        {
            this._context = pTWebContext;
        }

        [Route("product/{id?}")]
        public IActionResult Index(int? id)
        {
            Console.WriteLine(id);
            Product product = this._context.Products.Where(p => p.Id == id).First();
            return View(product);
        }
    }
}
