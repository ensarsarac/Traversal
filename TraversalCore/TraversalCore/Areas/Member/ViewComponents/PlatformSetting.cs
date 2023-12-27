using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.ViewComponents
{
    public class PlatformSetting : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;

        public PlatformSetting(UserManager<AppUser> userManager, IDestinationService destinationService, IReservationService reservationService)
        {
            _userManager = userManager;
            _destinationService = destinationService;
            _reservationService = reservationService;
        }
    

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = _reservationService.GetListAllWithManager(user.Id).Where(x=>x.Status == "Onaylandı").Count();
            ViewBag.v1 = _reservationService.GetListAllWithManager(user.Id).Where(x=>x.Status == "Onay Bekliyor").Count();
            ViewBag.v2 = _reservationService.GetListAllWithManager(user.Id).Where(x=>x.Status == "Geçmiş Rezervasyon").Count();
            return View();
        }
    }
}
