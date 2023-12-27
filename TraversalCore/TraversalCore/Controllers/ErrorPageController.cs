using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Controllers
{
    public class ErrorPageController : Controller
    {
        private readonly ILogger<ErrorPageController> _logger;

        public ErrorPageController(ILogger<ErrorPageController> logger)
        {
            _logger = logger;
        }

        public IActionResult Error404(int id)
        {
            _logger.LogInformation("Hata Sayfası");
            return View();
        }
    }
}
