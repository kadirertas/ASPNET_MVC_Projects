using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models.Entity;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class ShopingCartController : Controller
    {
        private readonly AppDbContext _context;

        public ShopingCartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int userId = 5; // Replace with actual user session
            var cartItems = GetCartItems(userId);

            // Sepetteki ürünlerin detay bilgilerini almak için boş bir liste oluştur
            var productsInCart = new List<Product>();

            // Her bir sepet öğesinin detay bilgilerini al
            foreach (var cartItem in cartItems)
            {
                // Sepetteki her ürünün detay bilgisini almak için ProductId kullanarak veritabanından çek
                var product = _context.Product.FirstOrDefault(p => p.ProductId == cartItem.ProductId);

                // Eğer ürün bulunduysa listeye ekle
                if (product != null)
                {
                    productsInCart.Add(product);
                }
            }

            // Sepetteki ürünlerin detay bilgileri ile birlikte view'a gönder
            return View(productsInCart);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            // Assume you have a repository or service to interact with the database
            var productToRemove = _context.Cart.FirstOrDefault(c => c.ProductId == productId);

            if (productToRemove != null)
            {
                _context.Cart.Remove(productToRemove);
                _context.SaveChanges();
                return Ok(); // or another appropriate response indicating success
            }
            else
            {
                return NotFound(); // or another appropriate response indicating failure
            }
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            int userId = 1; // Replace with actual user session
            AddToCartInternal(userId, productId);
            return NoContent();
        }

        public IActionResult Products()
        {
            // Mock data for products
            var products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Product 1", Price = 100, ImageUrl = "/images/product1.jpg" },
                new Product { ProductId = 2, ProductName = "Product 2", Price = 200, ImageUrl = "/images/product2.jpg" }
            };
            return View(products);
        }

        private void AddToCartInternal(int userId = 5, int productId = 1)
        {
            var cartItem = _context.Cart.FirstOrDefault(c => c.UserId == userId && c.ProductId == productId);
            if (cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                cartItem = new Cart
                {
                    UserId = 5,
                    ProductId = productId,
                    Quantity = 1,
                    CreatedData = DateTime.Now // CreatedDate'i manuel olarak ayarlıyoruz
                };
                _context.Cart.Add(cartItem);
            }

            _context.SaveChanges();
        }


        private List<Cart> GetCartItems(int userId)
        {
            return _context.Cart.Where(c => c.UserId == userId).ToList();
        }
    }
}
