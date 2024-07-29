using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoffeApp.Models.Entity;
using CoffeApp.Models;

namespace CoffeApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductsController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Products
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

        // GET: Products/Create
        public IActionResult Create()
        {
            var model = new Products();
            RefreshCategoryList();
            return View(model);
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products model, IFormFile ProductImageUrl)
        {
            if (ProductImageUrl != null && ProductImageUrl.Length > 0)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "Product");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(ProductImageUrl.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                string imageUrl = "/Product/" + uniqueFileName;

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ProductImageUrl.CopyToAsync(fileStream);
                }

                model.ProductImageUrl = imageUrl;
            }

            _context.Products.Add(model);
            await _context.SaveChangesAsync();
            RefreshCategoryList();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            RefreshCategoryList(product.CategoryId); // Mevcut kategoriyi yükle
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Products product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            RefreshCategoryList(product.CategoryId); // Mevcut kategoriyi yükle
            return View(product);
        }

        private void RefreshCategoryList(int selectedCategoryId = 0)
        {
            ViewBag.CategoryList = new SelectList(_context.Category.OrderBy(x => x.CategoryId), "CategoryId", "CategoryName", selectedCategoryId);
        }



        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            RefreshCategoryList();
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(product.ProductImageUrl))
            {
                string imagePath = Path.Combine("wwwroot", product.ProductImageUrl.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

   
        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
