using CoffeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var model = _context.Category.ToList();

            return View(model);
        }
    }
}
