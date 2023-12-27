using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Admin.CQRS2.Commands.Destinations;

namespace TraversalCore.Areas.Admin.CQRS2.Handlers.Destinations
{
    public class UpdateDestinationHandler
    {
        private readonly Context _context;

        public UpdateDestinationHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand p)
        {
            var value = _context.Destinations.Find(p.DestinationId);
            value.City = p.City;
            value.DayNight = p.DayNight;
            value.Price = p.Price;
            value.Capacity = p.Capacity;
            _context.SaveChanges();
        }



    }
}
