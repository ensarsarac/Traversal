using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]

    public class DestinationController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            DestinationManager dm = new DestinationManager(new EfDestinationRepository());
            var values = dm.TGetList().Where(x => x.Status == true).ToList();
            return View(values);
        }
    }
}
