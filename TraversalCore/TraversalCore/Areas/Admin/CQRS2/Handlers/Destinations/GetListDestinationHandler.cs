using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Admin.CQRS2.Results.Destinations;

namespace TraversalCore.Areas.Admin.CQRS2.Handlers.Destinations
{
    public class GetListDestinationHandler
    {
        private readonly Context _context;

        public GetListDestinationHandler(Context context)
        {
            _context = context;
        }

        public List<DestinationGetListResult> Handle()
        {
            var values = _context.Destinations.Select(x => new DestinationGetListResult
            {
                ID = x.DestinationId,
                City = x.City,
                Capacity = x.Capacity,
                DayNight = x.DayNight,
                Price = x.Price,
            }).AsNoTracking().ToList();
            return values;
        }

    }
}
