using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthController : Controller
    {
        IRepository<User> _repoUser;
        public AuthController(IRepository<User> repoUser)
        {
            _repoUser = repoUser;
        }
        public IActionResult Login()
        {
            return View();
        }

        // Veritabanında ilgili kullanıcı varmı
        // kullanıcının bilgileri çekicem
        // kullanıcı şifresi kriptolu vei ile eşleşiyormu kontrolü
        // kullanıcı rolüne göre sayfa yönlendirmesi

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            if (_repoUser.Any(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted))
            {
                User selectuser = _repoUser.Default(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted);
                bool isValid = BCrypt.Net.BCrypt.Verify(user.Password, selectuser.Password);
                if (isValid)
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim("userName",selectuser.UserName)  ,
                        new Claim("userId",selectuser.ID.ToString()) ,
                        new Claim("role",selectuser.Role.ToString())
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    if (selectuser.Role == Enums.Role.admin)
                    {
                        return RedirectToAction("Index", "Home", new { area = "Management" });
                    }
                    else if (selectuser.Role == Enums.Role.user)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
