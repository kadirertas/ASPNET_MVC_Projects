using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models.Entity;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        [HttpGet]
        public IActionResult Index()
        {
            var categories = _context.Category.ToList();
            return View(categories);
        }

        // GET: Categories/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category, IFormFile categoryImage)
        {
           
                if (categoryImage != null)
                {
                    string uploadsFolder = Path.Combine("wwwroot", "Category");
                    string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(categoryImage.FileName);
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    string imageUrl = "/Category/" + uniqueFileName;

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await categoryImage.CopyToAsync(fileStream);
                    }

                    category.CategoryImageUrl = imageUrl;
                }

                category.CreatedDate = DateTime.Now;
                _context.Category.Add(category);
                await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Categories");


        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                // ID belirtilmemişse, yeni bir kategori oluşturuluyor demektir
                return RedirectToAction("Create");
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Category model)
        {
            if (id != model.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Güncelleme zamanını ayarla
                model.CreatedDate = DateTime.Now;

                // Kategori bilgisini güncelle
                _context.Category.Update(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Categories");
            }
            return View(model);
        }



        // GET: Categories/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(category.CategoryImageUrl))
            {
                string imagePath = Path.Combine("wwwroot", category.CategoryImageUrl.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }
    }
}
