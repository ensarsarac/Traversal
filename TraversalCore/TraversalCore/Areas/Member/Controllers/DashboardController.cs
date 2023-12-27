using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        DestinationManager dm = new DestinationManager(new EfDestinationRepository());

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = user;
            return View();
        }
    }
}
