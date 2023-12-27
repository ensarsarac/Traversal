using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commnentService;

        public CommentController(ICommentService commnentService)
        {
            _commnentService = commnentService;
        }

        public IActionResult Index()
        {
            var values = _commnentService.GetListWithIncludeManager();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var comment = _commnentService.TGetById(id);
            _commnentService.TDelete(comment);
            return RedirectToAction("Index");
        }


    }
}
