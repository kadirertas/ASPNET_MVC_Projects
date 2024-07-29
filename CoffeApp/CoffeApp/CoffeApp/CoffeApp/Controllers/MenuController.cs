using Microsoft.AspNetCore.Mvc;
using CoffeApp.Models;
using CoffeApp.Models.Entity;
namespace CoffeApp.Controllers
{
    public class MenuController : Controller
    {

        private readonly AppDbContext _context;

        public MenuController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Products.Select(p => new Products
            {
                ProductId = p.ProductId,
                CategoryId = p.CategoryId,
                ProductName = p.ProductName,
                Price = p.Price,
                ProductImageUrl = p.ProductImageUrl,
                Description = p.Description ?? "Açıklama Yok"
            }).ToList();
            return View(model);
        }
        public IActionResult Category(int categoryId)
        {
            var productsInCategory = _context.Products.Where(p => p.CategoryId == categoryId)
                                                       .Select(p => new Products
                                                       {
                                                           ProductId = p.ProductId,
                                                           CategoryId = p.CategoryId,
                                                           ProductName = p.ProductName,
                                                           Price = p.Price,
                                                           ProductImageUrl = p.ProductImageUrl,
                                                           Description = p.Description ?? "Açıklama Yok"
                                                       })
                                                        .ToList();
            return View("Index", productsInCategory);

        }


    }
}

