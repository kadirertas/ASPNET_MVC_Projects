using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models.Entity;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var products = await _context.Product.ToListAsync();
            return View(products);
        }



[HttpGet]
    public IActionResult Create()
    {
        var model = new Product();
        Yenile();
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product model, IFormFile productImage)
    {
        
       

        if (productImage != null)
        {
            string uploadsFolder = Path.Combine("wwwroot", "Product");
            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(productImage.FileName);
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            string imageUrl = "/Product/" + uniqueFileName;

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await productImage.CopyToAsync(fileStream);
            }

            model.ImageUrl = imageUrl; // Set the ImageUrl here
        }

        model.CreatedDate = DateTime.Now;
        _context.Product.Add(model);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    private void Yenile()
    {
        ViewBag.CategoryList = new SelectList(_context.Category.OrderBy(x => x.CategoryId)
                                                            .Select(x => new SelectListItem
                                                            {
                                                                Text = x.CategoryName, // Burada CategoryName özelliği kullanılıyor
                                                                Value = x.CategoryId.ToString()
                                                            }), "Value", "Text");
    }




        // GET: Products/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Update product details
                _context.Product.Update(product);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(product.ImageUrl))
            {
                string imagePath = Path.Combine("wwwroot", product.ImageUrl.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}
