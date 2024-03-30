using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest_AspNet.Data;

namespace Nest_AspNet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductSizeController : Controller
    {
        private readonly AppDbContext _context;
        public ProductSizeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var prSizes = await _context.ProductSizes
                        .Include(x=>x.Product)
                        .Include(x=>x.Size)
                        .ToListAsync();
            return View(prSizes);
        }
    }
}
