using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponents.Default
{
    public class _PopularDestination : ViewComponent
    {
        DestinationManager dm = new DestinationManager(new EfDestinationRepository());
        public IViewComponentResult Invoke()
        {
            var values = dm.TGetList().OrderByDescending(x=>x.DestinationId).Take(4).ToList();
            return View(values);
        }
    }
}
