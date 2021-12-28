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

        
    }
}
