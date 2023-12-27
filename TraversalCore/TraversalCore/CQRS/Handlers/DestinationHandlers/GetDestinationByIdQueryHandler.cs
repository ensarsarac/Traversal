using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.CQRS.Queries.DestinationQueries;
using TraversalCore.CQRS.Results.DestinationResults;

namespace TraversalCore.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinatonByIdQueryResult Handle(GetDestinationByIdQuery p)
        {
            var values = _context.Destinations.Find(p.id);
            
            return new GetDestinatonByIdQueryResult
            {
                Destinationid = values.DestinationId,
                City = values.City,
                Daynight = values.DayNight,
                Price = values.Price,
                Capacity = values.Capacity
            };
        }

    }
}
