using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.ViewComponents
{
    public class GuidesInfo : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        GuidesManager gm = new GuidesManager(new EfGuideRepository());
        public GuidesInfo(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var guides =  gm.TGetList();
            return View(guides);
        }
    }
}
