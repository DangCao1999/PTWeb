using Microsoft.AspNetCore.Mvc;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTWeb.ViewComponents
{
    public class CategoryViewComponent: ViewComponent
    {
        private readonly PTWebContext _context;
        public CategoryViewComponent(PTWebContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _context.Categories;
            return View("Category", categories);
        }
    }
}
