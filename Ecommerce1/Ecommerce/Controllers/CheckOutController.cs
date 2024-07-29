using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models.Entity;
using System.Collections.Generic;
using System.Linq;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly AppDbContext _context; // DbContext'inizi tanımlayın

        public CheckOutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // UserId'si 5 olan Cartları bul
            var userCarts = _context.Carts.Where(c => c.UserId == 5).ToList();

            // Cartlardan alınan ProductId'leri kullanarak ilgili ürünleri Product tablosundan çek
            var products = new List<ProductViewModel>();
            foreach (var cart in userCarts)
            {
                var product = _context.Product.FirstOrDefault(p => p.ProductId == cart.ProductId);
                if (product != null)
                {
                    // ViewModel'e ekle
                    products.Add(new ProductViewModel
                    {
                        ProductName = product.ProductName,
                        Price = product.Price
                    });
                }
            }

            return View(products); // ViewModel'i View'a aktar
        }
    }

    // ViewModel
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
