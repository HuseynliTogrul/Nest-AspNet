using Microsoft.AspNetCore.Mvc;
using Nest_AspNet.Data;

namespace Nest_AspNet.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public CategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Categories.Include(x => x.Products).ToListAsync();
            return View(categories);
        }
    }
}
