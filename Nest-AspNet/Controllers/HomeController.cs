using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Nest_AspNet.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}