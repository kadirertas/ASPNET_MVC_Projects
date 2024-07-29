using Microsoft.AspNetCore.Mvc;

namespace CoffeApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
