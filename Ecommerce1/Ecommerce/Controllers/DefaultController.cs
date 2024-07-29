using Ecommerce.Models;
using Ecommerce.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ecommerce.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AppDbContext _context;

        public DefaultController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult AddSampleCategory()
        {
            // Örnek bir Category oluşturun
            var sampleCategory = new Category
            {
                CategoryName = "İçecek",
                CategoryImageUrl = "https://example.com/image223.jpg",
                IsActive = false,
                CreatedDate = DateTime.Now
            };

            // Veritabanına örnek kategoriyi ekleyin
            _context.Category.Add(sampleCategory);
            _context.SaveChanges();
            Console.WriteLine("Örnek kategori başarıyla eklendi.");
            // Ekleme işlemi başarılıysa ana sayfaya yönlendirin veya istediğiniz bir başka sayfaya yönlendirin
            return RedirectToAction("Index", "Default");
        }

        public IActionResult Index()
        {
            var categories = _context.Category.ToList();
            return View(categories);
        }
    }
}