using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.CQRS.Commands.DestinationCommands;
using TraversalCore.CQRS.Handlers.DestinationHandlers;
using TraversalCore.CQRS.Queries.DestinationQueries;
using TraversalCore.CQRS.Results.DestinationResults;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        private readonly DeleteDestinationCommandHandler _deleteDestinationCommandHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler, DeleteDestinationCommandHandler deleteDestinationCommandHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
            _deleteDestinationCommandHandler = deleteDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery {id = id });
            return View(values);
        }


        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(CreateDestination command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery { id=id});
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationCommand p)
        {
            _updateDestinationCommandHandler.Handle(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteDestination(int id)
        {
            _deleteDestinationCommandHandler.Handle(id);
            return RedirectToAction("Index");
        }




    }
}
