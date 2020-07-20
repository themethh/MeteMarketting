using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.MVCWebPageArayuz.Entity;
using MeteMarketting.MVCWebPageArayuz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MeteMarketting.MVCWebPageArayuz.Controllers
{
    public class UyeController:Controller
    {
        private UserManager<CustomKimlikUser> _userManager;
        private RoleManager<CustomKimlikRole> _roleManager;
        private SignInManager<CustomKimlikUser> _signInManager;

        public UyeController(UserManager<CustomKimlikUser> userManager, RoleManager<CustomKimlikRole> roleManager, SignInManager<CustomKimlikUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public ActionResult Kayitol()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult Kayitol(KayitolViewModel kayitolViewModel)
        {
            if (ModelState.IsValid)
            {
                CustomKimlikUser user = new CustomKimlikUser
                {
                  UserName = kayitolViewModel.KullaniciAdi,
                  Email = kayitolViewModel.Email
                    
                };
                IdentityResult result =
                    _userManager.CreateAsync(user, kayitolViewModel.Parola).Result;

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("Admin").Result)
                    {
                        CustomKimlikRole role = new CustomKimlikRole
                        {
                            Name = "Admin"
                        };
                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("","Eklenemedi");
                            return View(kayitolViewModel);
                        }
                        
                    }

                    _userManager.AddToRolesAsync(user, new[] {"Edit"});
                    return RedirectToAction("Giris", "Uye");
                }
                
            }

            return View(kayitolViewModel);

        }

        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(GirisViewModel girisViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(girisViewModel.KullaniciAdi, girisViewModel.Parola,
                    girisViewModel.RememberMe, false).Result;
            

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin");
            }
            ModelState.AddModelError("","Giris Basarısız");
            }

            return View(girisViewModel);
        }

       
    }
}
