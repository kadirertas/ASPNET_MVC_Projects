using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

public class ShopController : Controller
{
    private readonly AppDbContext _context;

    public ShopController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var model = _context.Product.ToList();
        return View(model);
    }

    public IActionResult Category(int categoryId)
    {
        var productsInCategory = _context.Product.Where(p => p.CategoryId == categoryId).ToList();
        return View("Index", productsInCategory);
    }
}
