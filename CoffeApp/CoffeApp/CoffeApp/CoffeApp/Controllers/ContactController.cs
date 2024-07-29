using Microsoft.AspNetCore.Mvc;

namespace CoffeApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
