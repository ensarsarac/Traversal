using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.CQRS2.Handlers.Destinations
{
    public class DeleteDestinationHandler
    {
        private readonly Context _context;

        public DeleteDestinationHandler(Context context)
        {
            _context = context;
        }

        public void Handle(int id)
        {
            var value = _context.Destinations.Find(id);
            _context.Destinations.Remove(value);
            _context.SaveChanges();
        }
    }
}
