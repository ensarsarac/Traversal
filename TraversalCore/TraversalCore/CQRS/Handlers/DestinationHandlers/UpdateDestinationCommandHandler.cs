using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.CQRS.Commands.DestinationCommands;
using TraversalCore.CQRS.Queries.DestinationQueries;

namespace TraversalCore.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }


        public void Handle(UpdateDestinationCommand p)
        {

            var destination = _context.Destinations.Find(p.Destinationid);
            destination.City = p.City;
            destination.DayNight = p.Daynight;
            destination.Price = p.Price;
            destination.Capacity = p.Capacity;
            _context.SaveChanges();
        }



    }
}
