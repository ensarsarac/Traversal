using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Admin.CQRS2.Commands.Destinations;
using TraversalCore.Areas.Admin.CQRS2.Handlers.Destinations;
using TraversalCore.Areas.Admin.CQRS2.Queries.Destinations;
using TraversalCore.Areas.Admin.CQRS2.Results.Destinations;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRS2Controller : Controller
    {
        private readonly GetListDestinationHandler _getListDestinationHandler;
        private readonly GetByIdDestinationHandler _getByIdDestinationHandler;
        private readonly UpdateDestinationHandler _updateDestinationHandler;
        private readonly AddDestinationHandler _addDestinationHandler;
        private readonly DeleteDestinationHandler _deleteDestinationHandler;

        public DestinationCQRS2Controller(GetListDestinationHandler getListDestinationHandler, GetByIdDestinationHandler getByIdDestinationHandler, UpdateDestinationHandler updateDestinationHandler, AddDestinationHandler addDestinationHandler, DeleteDestinationHandler deleteDestinationHandler)
        {
            _getListDestinationHandler = getListDestinationHandler;
            _getByIdDestinationHandler = getByIdDestinationHandler;
            _updateDestinationHandler = updateDestinationHandler;
            _addDestinationHandler = addDestinationHandler;
            _deleteDestinationHandler = deleteDestinationHandler;
        }

        public IActionResult Index()
        {
            var values = _getListDestinationHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _getByIdDestinationHandler.Handle(new GetByIdDestinationQuery() { id = id });
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(UpdateDestinationCommand p)
        {
            _updateDestinationHandler.Handle(p);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new AddDestinationCommand());
        }

        [HttpPost]
        public IActionResult Add(AddDestinationCommand p)
        {
            _addDestinationHandler.Handle(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _deleteDestinationHandler.Handle(id);
            return RedirectToAction("Index");
        }

    }
}
