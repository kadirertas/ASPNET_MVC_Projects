using Microsoft.AspNetCore.Mvc;

namespace FitnessTracking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
