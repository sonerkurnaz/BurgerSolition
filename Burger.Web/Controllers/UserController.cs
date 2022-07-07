using Burger.BL.Abstract;
using Burger.Entities;
using Burger.Web.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Burger.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManager manager;

        public UserController(IUserManager manager)
        {
            this.manager = manager;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            RegisterDTO dto = new();
            return View(dto);
        }
        [HttpPost]
        public IActionResult Register(RegisterDTO dTO)
        {
            if (ModelState.IsValid)
            {
                Kullanicilar yeniKullaici = new();
                yeniKullaici.Ad = dTO.Ad;
                yeniKullaici.Soyad = dTO.Soyad;
                yeniKullaici.Email = dTO.Email;
                yeniKullaici.Password = dTO.Password;

            }
            return View(dTO);
        }
    }
}
