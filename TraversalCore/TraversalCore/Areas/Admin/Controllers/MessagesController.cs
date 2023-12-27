using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessagesController : Controller
    {
        private readonly IWriteUsService _writeUsService;

        public MessagesController(IWriteUsService writeUsService)
        {
            _writeUsService = writeUsService;
        }

        public IActionResult Index()
        {
            var values = _writeUsService.TGetList().OrderByDescending(x=>x.Date).ToList();
            return View(values);
        }

        public IActionResult Details(int id)
        {
            var value = _writeUsService.TGetById(id);
            return View(value);
        }

        public IActionResult Delete(int id)
        {
            var value = _writeUsService.TGetById(id);
            _writeUsService.TDelete(value);
            return RedirectToAction("Index");
        }


    }
}
