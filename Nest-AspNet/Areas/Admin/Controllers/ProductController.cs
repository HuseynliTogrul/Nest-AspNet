using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest_AspNet.Data;
using Nest_AspNet.Models;

namespace Nest_AspNet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products
                                .Include(x => x.ProductImages)
                                .Include(x => x.Category)
                                .ToListAsync();
            return View(products);
        }
    }
}
