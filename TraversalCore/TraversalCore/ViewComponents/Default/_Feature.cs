using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FeatureManager fm = new FeatureManager(new EfFeatureRepository());
            //var values = fm.TGetList();
            ViewBag.v1 = fm.GetById(1);
            ViewBag.v3 = fm.GetById(3);
            ViewBag.v4 = fm.GetById(4);
            ViewBag.v5 = fm.GetById(5);
            ViewBag.v6 = fm.GetById(6);
            return View();
        }
    }
}
