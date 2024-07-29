using Microsoft.AspNetCore.Mvc;

namespace CoffeApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
