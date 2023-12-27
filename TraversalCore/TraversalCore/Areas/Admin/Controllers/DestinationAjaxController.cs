using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DestinationAjaxController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetList()
        {
            DestinationManager dm = new DestinationManager(new EfDestinationRepository());
            var jsonCity = JsonConvert.SerializeObject(dm.TGetList());
            return Json(jsonCity);
        }

        public IActionResult GetById(int id)
        {
            DestinationManager dm = new DestinationManager(new EfDestinationRepository());
            var jsonCity = JsonConvert.SerializeObject(dm.TGetById(id));
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddDestination(Destination d)
        {
            d.Status = true;
            d.Image = "/Traversal-Starter/assets/images/g1.jpg";    
            DestinationManager dm = new DestinationManager(new EfDestinationRepository());
            dm.TAdd(d);
            var jsonCity = JsonConvert.SerializeObject(d);
            return Json(jsonCity);
        }

        public IActionResult RemoveDestination(int id)
        {
            DestinationManager dm = new DestinationManager(new EfDestinationRepository());
            var des = dm.TGetById(id);
            dm.TDelete(des);
            var jsonCity = JsonConvert.SerializeObject(des);
            return Json(jsonCity);
        }

        
        public IActionResult UpdateDestination(Destination d)
        {
            DestinationManager dm = new DestinationManager(new EfDestinationRepository());
            dm.TUpdate(d);
            var jsonCity = JsonConvert.SerializeObject(d);
            return Json(jsonCity);
        }


    }
}
