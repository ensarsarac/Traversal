using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]

    public class ReservationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EfDestinationRepository());
        ReservationManager rm = new ReservationManager(new EfReservationRepository());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = rm.GetListByCurrentManager(user.Id);
            return View(values);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = rm.GetListByOldManager(user.Id);
            return View(values);
           
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = rm.GetListByApprovalManager(user.Id);
            return View(values);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {

            var values = new SelectList(dm.TGetList(), "DestinationId", "City");
            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = user.Id;
            p.Status = "Onay Bekliyor";
            rm.TAdd(p);
            return View();
        }


    }
}
