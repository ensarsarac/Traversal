using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Admin.CQRS2.Commands.Destinations;

namespace TraversalCore.Areas.Admin.CQRS2.Handlers.Destinations
{
    public class AddDestinationHandler
    {
        private readonly Context _context;

        public AddDestinationHandler(Context context)
        {
            _context = context;
        }

        public void Handle(AddDestinationCommand p)
        {
            var values = new Destination()
            {
                City = p.City,
                DayNight = p.DayNight,
                Price = p.Price,
                Capacity = p.Capacity,
                Status = p.Status
            };
            _context.Destinations.Add(values);
            _context.SaveChanges();
        }


    }
}
