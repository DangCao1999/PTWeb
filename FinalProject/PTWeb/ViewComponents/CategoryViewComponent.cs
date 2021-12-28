using Microsoft.AspNetCore.Mvc;
using PTWeb.Areas.Identity.Data;
using PTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTWeb.ViewComponents
{
    public class CategoryViewComponent: ViewComponent
    {
        private readonly IdentityDBContext _context;
        public CategoryViewComponent(IdentityDBContext context)
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
