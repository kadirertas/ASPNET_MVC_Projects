using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ecommerce.Models.Entity;
using System;
using System.IO;
using System.Linq;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
   
        public IActionResult Login(string userName, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);

            if (user != null)
            {
                

                // Kullanıcı doğrulandı, rolüne göre yönlendirme yap
                if (user.RolId == 1) // Admin rolü
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if (user.RolId == 2) // User rolü
                {
                    return RedirectToAction("Index", "Default"); // Veya başka bir default sayfa
                }
            }

            ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Users user, IFormFile profilePicture)
        {
            // Kullanıcı adının sistemde zaten var olup olmadığını kontrol et
            var existingUser = _context.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (existingUser != null)
            {
                ModelState.AddModelError("UserName", "Bu kullanıcı adı zaten mevcut");
                return View(user);
            }

            if (profilePicture != null)
            {
                // Resmi wwwroot/images klasörüne kaydetme
                string uploadsFolder = Path.Combine("wwwroot", "images");
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(profilePicture.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                string imageUrl = "/images/" + uniqueFileName;

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    profilePicture.CopyTo(fileStream);
                }

                // ImageUrl özelliğini ayarlama
                user.ImageUrl = imageUrl;
            }

            // Kullanıcıyı veritabanına ekleme
            user.CreatedData = DateTime.Now; // Oluşturma tarihini ayarla
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login", "Users"); // veya başka bir sayfaya yönlendirme
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Users");
        }
    }
}
