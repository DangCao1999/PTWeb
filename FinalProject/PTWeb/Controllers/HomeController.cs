using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PTWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PTWebContext _context;

        public HomeController(ILogger<HomeController> logger, PTWebContext pTWebContext)
        {
            _logger = logger;
            this._context = pTWebContext;        
        }

        public IActionResult Index()
        {
            List<Product> products1 = _context.Products.Take(3).ToList();
            List<Product> products2 = _context.Products.Skip(3).Take(3).ToList();
            ViewBag.products1 = products1;
            ViewBag.products2 = products2;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
