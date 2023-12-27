using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Member.ViewComponents
{
    public class LastDestination : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public LastDestination(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {

            return View(_destinationService.TGetListWithInclude().OrderByDescending(x=>x.Date).Take(3).ToList());
        }
    }
}
