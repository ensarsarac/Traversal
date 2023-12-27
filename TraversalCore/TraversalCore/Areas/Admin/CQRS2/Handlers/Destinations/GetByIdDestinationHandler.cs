using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Admin.CQRS2.Queries.Destinations;
using TraversalCore.Areas.Admin.CQRS2.Results.Destinations;

namespace TraversalCore.Areas.Admin.CQRS2.Handlers.Destinations
{
    public class GetByIdDestinationHandler
    {
        private readonly Context _context;

        public GetByIdDestinationHandler(Context context)
        {
            _context = context;
        }

        public GetByIdDestinationResult Handle(GetByIdDestinationQuery p)
        {

            var values = _context.Destinations.Find(p.id);
            return new GetByIdDestinationResult
            {
                City = values.City,
                Capacity = values.Capacity,
                DestinationId = values.DestinationId,
                DayNight = values.DayNight,
                Price = values.Price,
            };
        }




    }
}
