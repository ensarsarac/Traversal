using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Member.Models;

namespace TraversalCore.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public ProfileController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileViewModel model = new ProfileViewModel()
            {
                name = user.Name,
                surname = user.Surname,
                email = user.Email,
                phonenumber = user.PhoneNumber,
            };
            return View(model);
        }
    
        
        [HttpPost]
        public async Task<IActionResult> Index(ProfileViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (model.imageurl != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(model.imageurl.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/ProfileImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                
                await model.imageurl.CopyToAsync(stream);
                user.ImageUrl = imagename;
                
            }

            user.Name = model.name;
            user.Surname = model.surname;
            user.Email = model.email;
            user.PhoneNumber = model.phonenumber;

            if(model.password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.password);
            }
            var result =await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn","Login", new {area="" });
            }

            return View();
        }
    

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn", "Login", new { area=""});
        }


    }
}
