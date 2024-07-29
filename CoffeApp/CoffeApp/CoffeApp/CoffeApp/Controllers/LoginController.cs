using CoffeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace CoffeApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Kullanıcıyı doğrulama işlemi
            var user = _context.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);
            if (user != null)
            {
                // Kullanıcı kimlik bilgilerini oluşturma
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName)
            // İhtiyaç duyduğunuz başka iddiaları ekleyebilirsiniz
        };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // Oturumu başlatmak için HttpContext.SignInAsync'i çağırın
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Hatalı giriş
                ViewBag.Error = "Geçersiz kullanıcı adı veya şifre.";
                return View();
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }
    }
}
