using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponents.Default
{
    public class _Testimonials : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            TestimonialManager tm = new TestimonialManager(new EfTestimonialRepository());
            //DestinationManager dm = new DestinationManager(new EfDestinationRepository());
            var values = tm.TGetList();
            return View(values);
        }
    }
}
