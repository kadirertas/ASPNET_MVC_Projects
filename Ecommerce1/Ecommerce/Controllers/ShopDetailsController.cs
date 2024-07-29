using System.Linq;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers
{
    public class ShopDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public ShopDetailsController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index(int id)
        {
            var product = _context.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}