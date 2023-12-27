using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SubAboutManager manager = new SubAboutManager(new EfSubAboutRepository());
            var values = manager.TGetList();
            return View(values);
        }
    }
}
