using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.CQRS.Queries.DestinationQueries;
using TraversalCore.CQRS.Results.DestinationResults;

namespace TraversalCore.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x=> new GetAllDestinationQueryResult{
            
                id = x.DestinationId,
                capacity = x.Capacity,
                city = x.City,
                price = x.Price,
                daynight = x.DayNight,
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
