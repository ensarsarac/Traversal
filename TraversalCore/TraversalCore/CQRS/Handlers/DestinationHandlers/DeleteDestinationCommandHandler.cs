using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.CQRS.Handlers.DestinationHandlers
{
    public class DeleteDestinationCommandHandler
    {
        private readonly Context _context;

        public DeleteDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(int id)
        {
            var value = _context.Destinations.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
        }
    }
}
